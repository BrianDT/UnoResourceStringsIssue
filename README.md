# UnoResourceStringsIssue
Demonstrates a Uno WASM / iOS / Android issue with the use of programmatically acquiring strings from the reaw file.

Discussion no 11658

Confirmed resolved 14-March-2023

The sample confirms that if the item group to include the resw files is added to the common library

	<ItemGroup>
		<PRIResource Include="**\*.resw" />
	</ItemGroup>

	and the assemply name is added to the ResourceLoader. GetForCurrentView call the strings are retrieved.

#if HAS_UNO
                    this.resourceLoader = ResourceLoader.GetForCurrentView(assemblyName + "/Resources");
#else
                    this.resourceLoader = ResourceLoader.GetForViewIndependentUse(assemblyName + "/Resources");
#endif

