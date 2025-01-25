using System;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace Server.Helper
{
	// Token: 0x02000031 RID: 49
	public static class CreateCertificate
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0000E680 File Offset: 0x0000C880
		public static X509Certificate2 CreateCertificateAuthority(string caName, int keyStrength)
		{
			SecureRandom secureRandom = new SecureRandom(new CryptoApiRandomGenerator());
			RsaKeyPairGenerator rsaKeyPairGenerator = new RsaKeyPairGenerator();
			rsaKeyPairGenerator.Init(new KeyGenerationParameters(secureRandom, keyStrength));
			AsymmetricCipherKeyPair asymmetricCipherKeyPair = rsaKeyPairGenerator.GenerateKeyPair();
			X509V3CertificateGenerator x509V3CertificateGenerator = new X509V3CertificateGenerator();
			X509Name x509Name = new X509Name("CN=" + caName);
			BigInteger serialNumber = BigInteger.ProbablePrime(120, secureRandom);
			x509V3CertificateGenerator.SetSerialNumber(serialNumber);
			x509V3CertificateGenerator.SetSubjectDN(x509Name);
			x509V3CertificateGenerator.SetIssuerDN(x509Name);
			x509V3CertificateGenerator.SetNotAfter(DateTime.MaxValue);
			x509V3CertificateGenerator.SetNotBefore(DateTime.UtcNow.Subtract(new TimeSpan(2, 0, 0, 0)));
			x509V3CertificateGenerator.SetPublicKey(asymmetricCipherKeyPair.Public);
			x509V3CertificateGenerator.AddExtension(X509Extensions.SubjectKeyIdentifier, false, new SubjectKeyIdentifierStructure(asymmetricCipherKeyPair.Public));
			x509V3CertificateGenerator.AddExtension(X509Extensions.BasicConstraints, true, new BasicConstraints(true));
			ISignatureFactory signatureFactory = new Asn1SignatureFactory("SHA512WITHRSA", asymmetricCipherKeyPair.Private, secureRandom);
			return new X509Certificate2(DotNetUtilities.ToX509Certificate(x509V3CertificateGenerator.Generate(signatureFactory)))
			{
				PrivateKey = DotNetUtilities.ToRSA(asymmetricCipherKeyPair.Private as RsaPrivateCrtKeyParameters)
			};
		}
	}
}
