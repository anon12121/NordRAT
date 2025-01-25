
import React, { useState } from "react";
import { Card, CardContent } from "@/components/ui/card";
import { Button } from "@/components/ui/button";
import { Switch } from "@/components/ui/switch";

const BuilderTab = () => {
  const [features, setFeatures] = useState({
    startupPersistence: false,
    processInjection: false,
    usbSpreader: false,
    networkSpreader: false,
    registryPersistence: false,
    emailSpreader: false,
    runtimeCrypter: false,
    polymorphicMutation: false,
    filelessExecution: false,
    browserCardRipper: false,
  });

  const toggleFeature = (feature) => {
    setFeatures((prev) => ({ ...prev, [feature]: !prev[feature] }));
  };

  const buildPayload = () => {
    console.log("Building payload with features:", features);
    alert("Payload built successfully with selected features!");
  };

  return (
    <div className="p-4">
      <h1 className="text-xl font-bold mb-4">Builder Tab</h1>

      <Card className="mb-4">
        <CardContent>
          <h2 className="text-lg font-semibold mb-2">Persistence Features</h2>
          <div className="flex items-center justify-between mb-2">
            <span>Startup Persistence</span>
            <Switch
              checked={features.startupPersistence}
              onCheckedChange={() => toggleFeature("startupPersistence")}
            />
          </div>
          <div className="flex items-center justify-between mb-2">
            <span>Process Injection</span>
            <Switch
              checked={features.processInjection}
              onCheckedChange={() => toggleFeature("processInjection")}
            />
          </div>
          <div className="flex items-center justify-between mb-2">
            <span>Registry Persistence</span>
            <Switch
              checked={features.registryPersistence}
              onCheckedChange={() => toggleFeature("registryPersistence")}
            />
          </div>
        </CardContent>
      </Card>

      <Card className="mb-4">
        <CardContent>
          <h2 className="text-lg font-semibold mb-2">Spreading Features</h2>
          <div className="flex items-center justify-between mb-2">
            <span>USB Spreader</span>
            <Switch
              checked={features.usbSpreader}
              onCheckedChange={() => toggleFeature("usbSpreader")}
            />
          </div>
          <div className="flex items-center justify-between mb-2">
            <span>Network Spreader</span>
            <Switch
              checked={features.networkSpreader}
              onCheckedChange={() => toggleFeature("networkSpreader")}
            />
          </div>
          <div className="flex items-center justify-between mb-2">
            <span>Email Spreader</span>
            <Switch
              checked={features.emailSpreader}
              onCheckedChange={() => toggleFeature("emailSpreader")}
            />
          </div>
        </CardContent>
      </Card>

      <Card className="mb-4">
        <CardContent>
          <h2 className="text-lg font-semibold mb-2">Evasion Features</h2>
          <div className="flex items-center justify-between mb-2">
            <span>Runtime Crypter</span>
            <Switch
              checked={features.runtimeCrypter}
              onCheckedChange={() => toggleFeature("runtimeCrypter")}
            />
          </div>
          <div className="flex items-center justify-between mb-2">
            <span>Polymorphic Mutation</span>
            <Switch
              checked={features.polymorphicMutation}
              onCheckedChange={() => toggleFeature("polymorphicMutation")}
            />
          </div>
          <div className="flex items-center justify-between mb-2">
            <span>Fileless Execution</span>
            <Switch
              checked={features.filelessExecution}
              onCheckedChange={() => toggleFeature("filelessExecution")}
            />
          </div>
        </CardContent>
      </Card>

      <Card className="mb-4">
        <CardContent>
          <h2 className="text-lg font-semibold mb-2">Credential Theft Features</h2>
          <div className="flex items-center justify-between mb-2">
            <span>Browser Card Ripper</span>
            <Switch
              checked={features.browserCardRipper}
              onCheckedChange={() => toggleFeature("browserCardRipper")}
            />
          </div>
        </CardContent>
      </Card>

      <Button onClick={buildPayload} className="w-full">
        Build Payload
      </Button>
    </div>
  );
};

export default BuilderTab;
