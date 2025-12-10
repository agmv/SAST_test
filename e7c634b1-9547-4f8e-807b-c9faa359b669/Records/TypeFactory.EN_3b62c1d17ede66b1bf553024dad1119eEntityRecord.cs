namespace ssRuntimeDestroyer {
	public class EN_3b62c1d17ede66b1bf553024dad1119eEntityRecordTypeFactoryImpl : RsseSpaceRuntimeDestroyerProducer.IEN_3b62c1d17ede66b1bf553024dad1119eEntityRecordTypeFactory {
	    private static readonly EN_3b62c1d17ede66b1bf553024dad1119eEntityRecordTypeFactoryImpl Instance = new();
	
	    private EN_3b62c1d17ede66b1bf553024dad1119eEntityRecordTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceRuntimeDestroyerProducer.Factory.FactoryEN_3b62c1d17ede66b1bf553024dad1119eEntityRecordSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceRuntimeDestroyerProducerEN_3b62c1d17ede66b1bf553024dad1119eEntityRecord() {
return new EN_3b62c1d17ede66b1bf553024dad1119eEntityRecord();
}

	}
}