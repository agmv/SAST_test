namespace ssRuntimeDestroyer {
	public class RC_37793b7d6834fb46c2d504f9d8c91d4aTypeFactoryImpl : RsseSpaceRuntimeDestroyerProducer.IRC_37793b7d6834fb46c2d504f9d8c91d4aTypeFactory {
	    private static readonly RC_37793b7d6834fb46c2d504f9d8c91d4aTypeFactoryImpl Instance = new();
	
	    private RC_37793b7d6834fb46c2d504f9d8c91d4aTypeFactoryImpl() {}
	
		public static void InitializeFactory() {
            RsseSpaceRuntimeDestroyerProducer.Factory.FactoryRC_37793b7d6834fb46c2d504f9d8c91d4aSingleton = Instance;

		}
		
		public IRecord CreateRsseSpaceRuntimeDestroyerProducerRC_37793b7d6834fb46c2d504f9d8c91d4a() {
return new RC_37793b7d6834fb46c2d504f9d8c91d4a();
}

	}
}