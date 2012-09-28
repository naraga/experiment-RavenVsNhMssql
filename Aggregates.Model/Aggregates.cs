namespace Aggregates.Model
{
using System;
using System.Collections.Generic;
using System.Linq;
public static class RootFactory
{
	 public static IEntity CreateRandomRoot()	{
		var rootIdx = RndData.GetInt(10);			if(rootIdx == 0) return RootClassb807b8935576469887f8f50e38374114.CreateWithRandomData();
		if(rootIdx == 1) return RootClassf2a6b5c63d7d4940a7c1a39b0617bbe0.CreateWithRandomData();
		if(rootIdx == 2) return RootClass98067d615c3841f58e89ee20c66d16c9.CreateWithRandomData();
		if(rootIdx == 3) return RootClassaf48c270af3b4ed8a9be6b3319bea7d4.CreateWithRandomData();
		if(rootIdx == 4) return RootClassa1ab7d51b1624b5ea8c87968e8faae65.CreateWithRandomData();
		if(rootIdx == 5) return RootClass6eefe6074b8c4201b77e8c282f25d602.CreateWithRandomData();
		if(rootIdx == 6) return RootClassc667e6a8488b4dedb38d5defaaa9fd9a.CreateWithRandomData();
		if(rootIdx == 7) return RootClassd80d0d24d0e843edad9d483952bd198e.CreateWithRandomData();
		if(rootIdx == 8) return RootClassc41c96f37df84e61b1eae7cdc09d9003.CreateWithRandomData();
		if(rootIdx == 9) return RootClassf348e5fde7ca4d2f8e5b00d2ab139525.CreateWithRandomData();
		throw new Exception("wrong root index");
	}
}

public class RootClassb807b8935576469887f8f50e38374114 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propa0b86a10136c4538bed25335f3ceded1 {get; set;}

	public virtual string Prop8eb5e04ea6674a2eb628cae8074a9769 {get; set;}

	public virtual int Propb70c2e56afd74f81821298747503107d {get; set;}

	public virtual string Prop94f9c9c306dc48c8a8b92e4f979f4400 {get; set;}

	public virtual int Propf0ff08781595451eab1c5e0cd8d0d05c {get; set;}

	public virtual string Prop86e02f6c384c42a3afe454524e475ef9 {get; set;}

	public virtual bool Prop056744aa99d94fafb8434b23e0711d14 {get; set;}

	public virtual bool Prop1c72095c40ad4a27914be438e4402593 {get; set;}

	public virtual string Propdce3dca948194885b98f291d658abdff {get; set;}

	public virtual string Propae141d62b8cd43ad89a3046408cfbc94 {get; set;}

	public virtual bool Prope32ab5b646ac47798793e53370e1ff4e {get; set;}

	public virtual bool Prop28500a50b7fe47b0b6f5ae7b2474c1e5 {get; set;}

public static RootClassb807b8935576469887f8f50e38374114 CreateWithRandomData()
{
	var x = new RootClassb807b8935576469887f8f50e38374114();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propa0b86a10136c4538bed25335f3ceded1 = RndData.GetInt();
	x.Prop8eb5e04ea6674a2eb628cae8074a9769 = RndData.GetString();
	x.Propb70c2e56afd74f81821298747503107d = RndData.GetInt();
	x.Prop94f9c9c306dc48c8a8b92e4f979f4400 = RndData.GetString();
	x.Propf0ff08781595451eab1c5e0cd8d0d05c = RndData.GetInt();
	x.Prop86e02f6c384c42a3afe454524e475ef9 = RndData.GetString();
	x.Prop056744aa99d94fafb8434b23e0711d14 = RndData.GetBool();
	x.Prop1c72095c40ad4a27914be438e4402593 = RndData.GetBool();
	x.Propdce3dca948194885b98f291d658abdff = RndData.GetString();
	x.Propae141d62b8cd43ad89a3046408cfbc94 = RndData.GetString();
	x.Prope32ab5b646ac47798793e53370e1ff4e = RndData.GetBool();
	x.Prop28500a50b7fe47b0b6f5ae7b2474c1e5 = RndData.GetBool();
return x;
}
}

public class RootClassf2a6b5c63d7d4940a7c1a39b0617bbe0 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop22d470b3fa1a44c98ef83d6a2a7847a8 {get; set;}

	public virtual string Propa07a500a830f417a82364ed1e5be4d6c {get; set;}

	public virtual string Prop362f40ca16a6424aa39a9d1a9353950d {get; set;}

	public virtual string Propf5d646d31180452ba2ed9b3c77ec362f {get; set;}

	public virtual bool Propad4c3e8cda4f45a59456e6be9e45d91b {get; set;}

	public virtual bool Prop532b701f4d794826957f75427cf5d02b {get; set;}

	public virtual int Prop6f4243f54b8140a0b7393e2c596c3443 {get; set;}

	public virtual int Prop341867e7389f4167a6d3f5c54cac5f2a {get; set;}

	public virtual bool Prop5032054cb9814931bd91fdc9b6fbc3e0 {get; set;}

	public virtual ICollection<Class52fae3543824470ca336f0e2bd1bbca2> Propc5baeeb5b57d473f8da7ea4e7aa1a162 {get; set;}

	public virtual int Prop55ed5b313c704b1088e5b9bd6a19f1f9 {get; set;}

	public virtual bool Propce6115f8688a4109a3d06bdcd139fd28 {get; set;}

	public virtual bool Prop2596c178614845df9ca8024397eafe93 {get; set;}

	public virtual bool Prop6af4a9e175e44945bae8ea008ece0b72 {get; set;}

	public virtual int Propbc26f906b4d14cb694f88dadf616a659 {get; set;}

	public virtual bool Prope0dbecad8e52492d8e615394ab51f339 {get; set;}

	public virtual bool Prop0d1f44a5069a46f1ac4fe3e81fd20627 {get; set;}

	public virtual bool Prop9f95749bf8c84b81a760964a2a064f1f {get; set;}

	public virtual bool Prop34dd7c0f1a584ebd9c8b970724094a9e {get; set;}

	public virtual bool Prop2e44fc8af76b47c5abf34f93adf789d3 {get; set;}

	public virtual int Prop714426c07eab485c953a2b9c0f79d20b {get; set;}

	public virtual int Propb37b901bc22840e1886ea5f140fe396b {get; set;}

	public virtual string Propc10213d27062416cb873e4b1071a842c {get; set;}

	public virtual int Prop06eefce4f9344a238dc0d59d76470452 {get; set;}

	public virtual string Prop89c4d5f73e5d4e9881ca6fcc77466023 {get; set;}

	public virtual bool Prop099f4a5f8d7e4e97b2ab768baa05ea26 {get; set;}

	public virtual int Propcd686e89f7dd4149835a7a9e9527c460 {get; set;}

	public virtual string Prop50829c3ca7874bc99026ae81234615fa {get; set;}

	public virtual string Propc5a4702566f24bcea5ecb6f37a711785 {get; set;}

public static RootClassf2a6b5c63d7d4940a7c1a39b0617bbe0 CreateWithRandomData()
{
	var x = new RootClassf2a6b5c63d7d4940a7c1a39b0617bbe0();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop22d470b3fa1a44c98ef83d6a2a7847a8 = RndData.GetInt();
	x.Propa07a500a830f417a82364ed1e5be4d6c = RndData.GetString();
	x.Prop362f40ca16a6424aa39a9d1a9353950d = RndData.GetString();
	x.Propf5d646d31180452ba2ed9b3c77ec362f = RndData.GetString();
	x.Propad4c3e8cda4f45a59456e6be9e45d91b = RndData.GetBool();
	x.Prop532b701f4d794826957f75427cf5d02b = RndData.GetBool();
	x.Prop6f4243f54b8140a0b7393e2c596c3443 = RndData.GetInt();
	x.Prop341867e7389f4167a6d3f5c54cac5f2a = RndData.GetInt();
	x.Prop5032054cb9814931bd91fdc9b6fbc3e0 = RndData.GetBool();
	x.Propc5baeeb5b57d473f8da7ea4e7aa1a162 = new List<Class52fae3543824470ca336f0e2bd1bbca2>(RndData.GetList(10, Class52fae3543824470ca336f0e2bd1bbca2.CreateWithRandomData));
	x.Prop55ed5b313c704b1088e5b9bd6a19f1f9 = RndData.GetInt();
	x.Propce6115f8688a4109a3d06bdcd139fd28 = RndData.GetBool();
	x.Prop2596c178614845df9ca8024397eafe93 = RndData.GetBool();
	x.Prop6af4a9e175e44945bae8ea008ece0b72 = RndData.GetBool();
	x.Propbc26f906b4d14cb694f88dadf616a659 = RndData.GetInt();
	x.Prope0dbecad8e52492d8e615394ab51f339 = RndData.GetBool();
	x.Prop0d1f44a5069a46f1ac4fe3e81fd20627 = RndData.GetBool();
	x.Prop9f95749bf8c84b81a760964a2a064f1f = RndData.GetBool();
	x.Prop34dd7c0f1a584ebd9c8b970724094a9e = RndData.GetBool();
	x.Prop2e44fc8af76b47c5abf34f93adf789d3 = RndData.GetBool();
	x.Prop714426c07eab485c953a2b9c0f79d20b = RndData.GetInt();
	x.Propb37b901bc22840e1886ea5f140fe396b = RndData.GetInt();
	x.Propc10213d27062416cb873e4b1071a842c = RndData.GetString();
	x.Prop06eefce4f9344a238dc0d59d76470452 = RndData.GetInt();
	x.Prop89c4d5f73e5d4e9881ca6fcc77466023 = RndData.GetString();
	x.Prop099f4a5f8d7e4e97b2ab768baa05ea26 = RndData.GetBool();
	x.Propcd686e89f7dd4149835a7a9e9527c460 = RndData.GetInt();
	x.Prop50829c3ca7874bc99026ae81234615fa = RndData.GetString();
	x.Propc5a4702566f24bcea5ecb6f37a711785 = RndData.GetString();
return x;
}
}

public class RootClass98067d615c3841f58e89ee20c66d16c9 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propb0aeb12f483e49bcac305ce329fb04b8 {get; set;}

	public virtual ICollection<Class8ddc74736e4340929c62b7cd5d01882c> Propc1eabc18ae7949908d014e30d5f3ed92 {get; set;}

	public virtual int Propf0cd427bf2794bf2b3379a6b2df41123 {get; set;}

	public virtual bool Propd5589bd6562441a88915b7b9300cda59 {get; set;}

	public virtual int Propb5dd784039d7410089e3d31dc849e636 {get; set;}

	public virtual bool Propce7da4f720f54cd7bc447003bf43b0a8 {get; set;}

	public virtual bool Prop96053fc31ba9420bafdc928f880cc751 {get; set;}

	public virtual bool Prop353534909b914433972ac3c52ff51855 {get; set;}

	public virtual bool Prop798862f0d39c474baf6a72d930b08c9e {get; set;}

	public virtual bool Prop616e6441161b4986bb8e168a9a939baa {get; set;}

	public virtual int Prop37ccaaf102a54246bd38f53a84b4e30d {get; set;}

	public virtual bool Prop9e2fa46921e54a2d89bcdb4053766e45 {get; set;}

	public virtual bool Prop83704049ac4f45458ba66b40e635cdf1 {get; set;}

	public virtual int Prop374d5dae27ac4d05a4355fdb0c6b8d2d {get; set;}

	public virtual bool Prop2f7c0eb822e24714b6bcbcd243ad2776 {get; set;}

	public virtual bool Prop7f2a5210c11f4660a3de29e364bbc0d7 {get; set;}

	public virtual bool Prop0f9543768e464f3e90aa454e9a19a514 {get; set;}

	public virtual int Prope922cb865b924075a6338d028ba58e47 {get; set;}

	public virtual int Propff594a9cb2484eefaf0e308367867e18 {get; set;}

	public virtual int Propcf424a42fb4e42d18698148d2a3706ee {get; set;}

	public virtual bool Prop06c33beb11ec4f4189233e9065fb5ced {get; set;}

	public virtual bool Propba5e1bac691c4c44a81022a81c444bdd {get; set;}

public static RootClass98067d615c3841f58e89ee20c66d16c9 CreateWithRandomData()
{
	var x = new RootClass98067d615c3841f58e89ee20c66d16c9();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propb0aeb12f483e49bcac305ce329fb04b8 = RndData.GetInt();
	x.Propc1eabc18ae7949908d014e30d5f3ed92 = new List<Class8ddc74736e4340929c62b7cd5d01882c>(RndData.GetList(10, Class8ddc74736e4340929c62b7cd5d01882c.CreateWithRandomData));
	x.Propf0cd427bf2794bf2b3379a6b2df41123 = RndData.GetInt();
	x.Propd5589bd6562441a88915b7b9300cda59 = RndData.GetBool();
	x.Propb5dd784039d7410089e3d31dc849e636 = RndData.GetInt();
	x.Propce7da4f720f54cd7bc447003bf43b0a8 = RndData.GetBool();
	x.Prop96053fc31ba9420bafdc928f880cc751 = RndData.GetBool();
	x.Prop353534909b914433972ac3c52ff51855 = RndData.GetBool();
	x.Prop798862f0d39c474baf6a72d930b08c9e = RndData.GetBool();
	x.Prop616e6441161b4986bb8e168a9a939baa = RndData.GetBool();
	x.Prop37ccaaf102a54246bd38f53a84b4e30d = RndData.GetInt();
	x.Prop9e2fa46921e54a2d89bcdb4053766e45 = RndData.GetBool();
	x.Prop83704049ac4f45458ba66b40e635cdf1 = RndData.GetBool();
	x.Prop374d5dae27ac4d05a4355fdb0c6b8d2d = RndData.GetInt();
	x.Prop2f7c0eb822e24714b6bcbcd243ad2776 = RndData.GetBool();
	x.Prop7f2a5210c11f4660a3de29e364bbc0d7 = RndData.GetBool();
	x.Prop0f9543768e464f3e90aa454e9a19a514 = RndData.GetBool();
	x.Prope922cb865b924075a6338d028ba58e47 = RndData.GetInt();
	x.Propff594a9cb2484eefaf0e308367867e18 = RndData.GetInt();
	x.Propcf424a42fb4e42d18698148d2a3706ee = RndData.GetInt();
	x.Prop06c33beb11ec4f4189233e9065fb5ced = RndData.GetBool();
	x.Propba5e1bac691c4c44a81022a81c444bdd = RndData.GetBool();
return x;
}
}

public class RootClassaf48c270af3b4ed8a9be6b3319bea7d4 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop69355eafc2954bf1ab6522630fb128d7 {get; set;}

	public virtual string Propbc376fd78be3481b849e6932abf224c5 {get; set;}

	public virtual int Propb5d8f4d0ca6641ef8d65b03f64c67cf6 {get; set;}

	public virtual string Prop7c06c48f4ce1423ea7ebed4e3a22fe7c {get; set;}

	public virtual string Prop269fc298d86b42b99e766b98ceda002f {get; set;}

	public virtual string Propfbef62021c3340e6b9d0f3788cef49c2 {get; set;}

	public virtual bool Prop2298d5a5d3d44975980220b41acb0291 {get; set;}

	public virtual int Propf2c1107b1b7845fb9edce249c5234079 {get; set;}

	public virtual int Propdbdbf62891ed4bc6889fd556962db7ee {get; set;}

	public virtual int Propfc1bee6d52364fb7882266f5f68cbbd0 {get; set;}

	public virtual int Prop2b92fbfc14f342d187eff58933728ea3 {get; set;}

	public virtual string Prop5c3b49ca56f34e358ca73f4af39c10d2 {get; set;}

	public virtual string Propb3d8b7ff2b614f06a9e0672924cc07f2 {get; set;}

	public virtual string Prop60fe7e2685ec4ca595af0a2e87a46b1d {get; set;}

	public virtual int Prop3df8a906d4ac4201b0a7976c269b0a09 {get; set;}

	public virtual ICollection<Class453f9ed8c4db40319708c5f741435b92> Propd965d787253046d8995bab31267782c5 {get; set;}

	public virtual string Prop93d00f6bea9c4338a6df734344d35019 {get; set;}

	public virtual string Prop5610765dc8d944e99373ef80c5a4f982 {get; set;}

	public virtual string Prop84d075d6048e4187b3cd074fe060f3a8 {get; set;}

	public virtual bool Prop3e73106859534303b5918fae8d06a2e9 {get; set;}

	public virtual bool Prop0c467bf4c24e422cb38ab8672eefc0d6 {get; set;}

	public virtual string Prop0e65acd8374a4c6c99b8ee3000f10392 {get; set;}

	public virtual string Prop5698c76269124b53a1c259509170447d {get; set;}

	public virtual string Prop5f95947369b7442cb515d460e99fc10a {get; set;}

	public virtual string Prop285397780e914fa2a9ddb7c836cfeb8e {get; set;}

public static RootClassaf48c270af3b4ed8a9be6b3319bea7d4 CreateWithRandomData()
{
	var x = new RootClassaf48c270af3b4ed8a9be6b3319bea7d4();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop69355eafc2954bf1ab6522630fb128d7 = RndData.GetInt();
	x.Propbc376fd78be3481b849e6932abf224c5 = RndData.GetString();
	x.Propb5d8f4d0ca6641ef8d65b03f64c67cf6 = RndData.GetInt();
	x.Prop7c06c48f4ce1423ea7ebed4e3a22fe7c = RndData.GetString();
	x.Prop269fc298d86b42b99e766b98ceda002f = RndData.GetString();
	x.Propfbef62021c3340e6b9d0f3788cef49c2 = RndData.GetString();
	x.Prop2298d5a5d3d44975980220b41acb0291 = RndData.GetBool();
	x.Propf2c1107b1b7845fb9edce249c5234079 = RndData.GetInt();
	x.Propdbdbf62891ed4bc6889fd556962db7ee = RndData.GetInt();
	x.Propfc1bee6d52364fb7882266f5f68cbbd0 = RndData.GetInt();
	x.Prop2b92fbfc14f342d187eff58933728ea3 = RndData.GetInt();
	x.Prop5c3b49ca56f34e358ca73f4af39c10d2 = RndData.GetString();
	x.Propb3d8b7ff2b614f06a9e0672924cc07f2 = RndData.GetString();
	x.Prop60fe7e2685ec4ca595af0a2e87a46b1d = RndData.GetString();
	x.Prop3df8a906d4ac4201b0a7976c269b0a09 = RndData.GetInt();
	x.Propd965d787253046d8995bab31267782c5 = new List<Class453f9ed8c4db40319708c5f741435b92>(RndData.GetList(10, Class453f9ed8c4db40319708c5f741435b92.CreateWithRandomData));
	x.Prop93d00f6bea9c4338a6df734344d35019 = RndData.GetString();
	x.Prop5610765dc8d944e99373ef80c5a4f982 = RndData.GetString();
	x.Prop84d075d6048e4187b3cd074fe060f3a8 = RndData.GetString();
	x.Prop3e73106859534303b5918fae8d06a2e9 = RndData.GetBool();
	x.Prop0c467bf4c24e422cb38ab8672eefc0d6 = RndData.GetBool();
	x.Prop0e65acd8374a4c6c99b8ee3000f10392 = RndData.GetString();
	x.Prop5698c76269124b53a1c259509170447d = RndData.GetString();
	x.Prop5f95947369b7442cb515d460e99fc10a = RndData.GetString();
	x.Prop285397780e914fa2a9ddb7c836cfeb8e = RndData.GetString();
return x;
}
}

public class RootClassa1ab7d51b1624b5ea8c87968e8faae65 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop9e29ec02f2264373ab230f326902009c {get; set;}

	public virtual string Prop3264f01b575c4ff8874a70c010988e04 {get; set;}

	public virtual string Prop236e15e6381f4927a5c12360a3b8faa4 {get; set;}

	public virtual string Propdb05f3d7fcf34890ad5cfb95600941d6 {get; set;}

	public virtual bool Prop99f994d93b694d8ebb69eefe2d5e4cf3 {get; set;}

	public virtual string Prop16417bd02c604cf5aa9a70f7515c81f7 {get; set;}

	public virtual string Propbbe7a4f54a63460fb304d8bd59ae2019 {get; set;}

	public virtual int Propf5aa6e1c2ddf437395de33bc648ab665 {get; set;}

	public virtual int Prop2180d68714cc45a080491f580ff44524 {get; set;}

	public virtual bool Propa14407f2295641f4a71eafc65cd644f0 {get; set;}

	public virtual int Propd78f1fb7fbd1458fab2759dde2185899 {get; set;}

	public virtual string Prop1ce2ea9e440a451fafa7c451a59b2ef3 {get; set;}

	public virtual string Prop3d0d581d99214afa8dfa669b5f7e8df0 {get; set;}

public static RootClassa1ab7d51b1624b5ea8c87968e8faae65 CreateWithRandomData()
{
	var x = new RootClassa1ab7d51b1624b5ea8c87968e8faae65();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop9e29ec02f2264373ab230f326902009c = RndData.GetBool();
	x.Prop3264f01b575c4ff8874a70c010988e04 = RndData.GetString();
	x.Prop236e15e6381f4927a5c12360a3b8faa4 = RndData.GetString();
	x.Propdb05f3d7fcf34890ad5cfb95600941d6 = RndData.GetString();
	x.Prop99f994d93b694d8ebb69eefe2d5e4cf3 = RndData.GetBool();
	x.Prop16417bd02c604cf5aa9a70f7515c81f7 = RndData.GetString();
	x.Propbbe7a4f54a63460fb304d8bd59ae2019 = RndData.GetString();
	x.Propf5aa6e1c2ddf437395de33bc648ab665 = RndData.GetInt();
	x.Prop2180d68714cc45a080491f580ff44524 = RndData.GetInt();
	x.Propa14407f2295641f4a71eafc65cd644f0 = RndData.GetBool();
	x.Propd78f1fb7fbd1458fab2759dde2185899 = RndData.GetInt();
	x.Prop1ce2ea9e440a451fafa7c451a59b2ef3 = RndData.GetString();
	x.Prop3d0d581d99214afa8dfa669b5f7e8df0 = RndData.GetString();
return x;
}
}

public class RootClass6eefe6074b8c4201b77e8c282f25d602 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop6295141ae265462493629d7cffb0b77d {get; set;}

	public virtual bool Prop5fb17ba0985845789762b53c7fd47a74 {get; set;}

	public virtual Classc0096349cfd94b58b2b2e08acabe6fd6 Propc211468eba0e42559874a57223167ecc {get; set;}

	public virtual bool Propffb6a4a61d5a4120a75e791d9c489685 {get; set;}

	public virtual ICollection<Classd6116ec6de184589937ee9856403d182> Prop6af7a281d0a94326b343fbddddfbe04a {get; set;}

	public virtual string Prop6fb96cd06be44a29b93eb533158fe5ae {get; set;}

	public virtual string Prop51aa4c24222e4a17a773491fbfe14243 {get; set;}

	public virtual int Prope270edd30d524b2cb199d105fcc55a62 {get; set;}

	public virtual string Propfccd15b31dd141dd835f27dc980fd9ce {get; set;}

	public virtual string Prop4dcdecd3dc884ab687c8991f395d35f1 {get; set;}

	public virtual bool Prop1d59ea97524842bbbc4dded137e35d92 {get; set;}

	public virtual string Propd049807a254e4bf88f3fb33c39a2d0c3 {get; set;}

	public virtual bool Prop0864cd2d6cf14b09807e5d74a9a7b384 {get; set;}

	public virtual int Prop09aacf9f539b4223beee7bb2e786c7b9 {get; set;}

	public virtual bool Propbfec6aab985143d997f0e51e31830cdc {get; set;}

	public virtual string Propb5e8e8bd5e5f4217bb78b6102c7d5068 {get; set;}

	public virtual int Prop4118e65ee06f417bb2e82dfa5f7aa2dc {get; set;}

	public virtual bool Prop2999cba42436493482030e436683c1fc {get; set;}

	public virtual string Propd60a63c983d74a8ab6f273b721a30426 {get; set;}

	public virtual bool Prop525722be2a664d93ac1fba87b402f805 {get; set;}

	public virtual int Prop446d8e68f973429aa23ff93e807c031d {get; set;}

	public virtual int Prop41b8ecdf8194406b82c40eeecd8ce719 {get; set;}

	public virtual bool Propb0c66f9c596a483d8d3e95e67edc00e8 {get; set;}

	public virtual Classdb291af8c4a54e819448c85e40563dbf Prop5e0904b9c3a845cfa11fb5c8e0f5dfa0 {get; set;}

	public virtual int Prop1b013a4bc8814eedbba18e0f11099b45 {get; set;}

public static RootClass6eefe6074b8c4201b77e8c282f25d602 CreateWithRandomData()
{
	var x = new RootClass6eefe6074b8c4201b77e8c282f25d602();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop6295141ae265462493629d7cffb0b77d = RndData.GetBool();
	x.Prop5fb17ba0985845789762b53c7fd47a74 = RndData.GetBool();
	x.Propc211468eba0e42559874a57223167ecc = Classc0096349cfd94b58b2b2e08acabe6fd6.CreateWithRandomData();
	x.Propffb6a4a61d5a4120a75e791d9c489685 = RndData.GetBool();
	x.Prop6af7a281d0a94326b343fbddddfbe04a = new List<Classd6116ec6de184589937ee9856403d182>(RndData.GetList(10, Classd6116ec6de184589937ee9856403d182.CreateWithRandomData));
	x.Prop6fb96cd06be44a29b93eb533158fe5ae = RndData.GetString();
	x.Prop51aa4c24222e4a17a773491fbfe14243 = RndData.GetString();
	x.Prope270edd30d524b2cb199d105fcc55a62 = RndData.GetInt();
	x.Propfccd15b31dd141dd835f27dc980fd9ce = RndData.GetString();
	x.Prop4dcdecd3dc884ab687c8991f395d35f1 = RndData.GetString();
	x.Prop1d59ea97524842bbbc4dded137e35d92 = RndData.GetBool();
	x.Propd049807a254e4bf88f3fb33c39a2d0c3 = RndData.GetString();
	x.Prop0864cd2d6cf14b09807e5d74a9a7b384 = RndData.GetBool();
	x.Prop09aacf9f539b4223beee7bb2e786c7b9 = RndData.GetInt();
	x.Propbfec6aab985143d997f0e51e31830cdc = RndData.GetBool();
	x.Propb5e8e8bd5e5f4217bb78b6102c7d5068 = RndData.GetString();
	x.Prop4118e65ee06f417bb2e82dfa5f7aa2dc = RndData.GetInt();
	x.Prop2999cba42436493482030e436683c1fc = RndData.GetBool();
	x.Propd60a63c983d74a8ab6f273b721a30426 = RndData.GetString();
	x.Prop525722be2a664d93ac1fba87b402f805 = RndData.GetBool();
	x.Prop446d8e68f973429aa23ff93e807c031d = RndData.GetInt();
	x.Prop41b8ecdf8194406b82c40eeecd8ce719 = RndData.GetInt();
	x.Propb0c66f9c596a483d8d3e95e67edc00e8 = RndData.GetBool();
	x.Prop5e0904b9c3a845cfa11fb5c8e0f5dfa0 = Classdb291af8c4a54e819448c85e40563dbf.CreateWithRandomData();
	x.Prop1b013a4bc8814eedbba18e0f11099b45 = RndData.GetInt();
return x;
}
}

public class RootClassc667e6a8488b4dedb38d5defaaa9fd9a : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propdbbbc5229eea4c0e907822fcffb03476 {get; set;}

	public virtual bool Propc2a8ab2f7a35475d860a1c11a931d1d9 {get; set;}

	public virtual string Propa9c399a73069415f9fa605127e9f6e55 {get; set;}

	public virtual int Prop11504c535cc546368422a169f92728b0 {get; set;}

	public virtual bool Prop6fa2af642f3c488fb77b6cb6485bf559 {get; set;}

	public virtual bool Propc2b96ea6c6a343d698d71a6b766fbace {get; set;}

	public virtual int Prop78ca1d4200fb431bb3f77836ade57211 {get; set;}

	public virtual int Prop94ffb16c4c494475934bdee6b9c279ed {get; set;}

	public virtual int Propfd61b32663124635a1be2880cfbea850 {get; set;}

	public virtual Classc555367b57f9489cbfb12cd63e2c13c7 Prop60e6a86b6cdd466d8e0196b94c89921d {get; set;}

	public virtual bool Prop246e6ebdf2bd4c659ae57bb0694c6375 {get; set;}

	public virtual string Prop708f21fef1f0445d901774c8a41ca2a1 {get; set;}

	public virtual int Prop5357df7af5f2407a95404a5a1e8c3ad3 {get; set;}

	public virtual int Prop2f89f9b7f2634879a9c2e787aaff047b {get; set;}

public static RootClassc667e6a8488b4dedb38d5defaaa9fd9a CreateWithRandomData()
{
	var x = new RootClassc667e6a8488b4dedb38d5defaaa9fd9a();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propdbbbc5229eea4c0e907822fcffb03476 = RndData.GetInt();
	x.Propc2a8ab2f7a35475d860a1c11a931d1d9 = RndData.GetBool();
	x.Propa9c399a73069415f9fa605127e9f6e55 = RndData.GetString();
	x.Prop11504c535cc546368422a169f92728b0 = RndData.GetInt();
	x.Prop6fa2af642f3c488fb77b6cb6485bf559 = RndData.GetBool();
	x.Propc2b96ea6c6a343d698d71a6b766fbace = RndData.GetBool();
	x.Prop78ca1d4200fb431bb3f77836ade57211 = RndData.GetInt();
	x.Prop94ffb16c4c494475934bdee6b9c279ed = RndData.GetInt();
	x.Propfd61b32663124635a1be2880cfbea850 = RndData.GetInt();
	x.Prop60e6a86b6cdd466d8e0196b94c89921d = Classc555367b57f9489cbfb12cd63e2c13c7.CreateWithRandomData();
	x.Prop246e6ebdf2bd4c659ae57bb0694c6375 = RndData.GetBool();
	x.Prop708f21fef1f0445d901774c8a41ca2a1 = RndData.GetString();
	x.Prop5357df7af5f2407a95404a5a1e8c3ad3 = RndData.GetInt();
	x.Prop2f89f9b7f2634879a9c2e787aaff047b = RndData.GetInt();
return x;
}
}

public class RootClassd80d0d24d0e843edad9d483952bd198e : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Propef9d736aa38e4585a5047ad1fa6ebdc6 {get; set;}

	public virtual string Prop8af285098bc34ed3a4be3b2a05cdbc50 {get; set;}

	public virtual string Prop9ce4bc83fb4d425da91b0c78d325c150 {get; set;}

	public virtual string Propd4eb2edb2e604bdfbefb358a8b91f7d3 {get; set;}

	public virtual bool Prop41e788ec1c884116b859c64a1048c726 {get; set;}

	public virtual string Prop05c9735f104a41e59fb8499318a69968 {get; set;}

	public virtual ICollection<Class50791ff63b0b4d1ba8f72f6e94db59cb> Prop1b93d1ccb16a4be6b0cd50a5ef54430a {get; set;}

	public virtual ICollection<Class89177451ab1d47c58931ac1289279779> Prop56575b6efa5d42f5b4caa01290bd8027 {get; set;}

	public virtual int Propdb50562ad1bf4254938cf707b8b477cc {get; set;}

	public virtual string Propf3158a4af866493b82c33eb54fd9fae1 {get; set;}

	public virtual int Propdf5b9bbe39cb43e9bd7868752ed8e1d1 {get; set;}

	public virtual int Propa786373542744eacb476a6dcb9eb6946 {get; set;}

	public virtual bool Propabf9e73afa9e420da8a811ebfc58f30b {get; set;}

	public virtual int Propa81c693939e241f4a704733dc54ac97f {get; set;}

	public virtual bool Prop1ea6542e9aca4e9fb710b38d0a0ec604 {get; set;}

	public virtual bool Prop812fd31ab85d40c286cae3444c6396b7 {get; set;}

	public virtual int Prop9149fed9cffe48d3b0e86926aafbce6b {get; set;}

	public virtual int Propc3bf106deef940a5a25be16ae89f1510 {get; set;}

	public virtual ICollection<Class28efa4143cd34244b347f84c460c6b93> Propb3498cbde4c14662b9cbd21a7e23d212 {get; set;}

	public virtual int Propc7655769465b4fd89e3072309171a7f4 {get; set;}

	public virtual int Prop578c847ad16046218f3d03c65ba9b739 {get; set;}

	public virtual bool Prop9f09af938bf34a6793aa02e7d3a02614 {get; set;}

	public virtual int Prop926896c7d9f04c748dfe4bb03fa94556 {get; set;}

	public virtual ICollection<Class4400b92ae3a3422aae70d3ad1c161279> Prop8a0bb435d1d948e7af9dd04f7b916fee {get; set;}

	public virtual string Propae81199454734e2299282b5179a81a5f {get; set;}

	public virtual string Propa0dbaeb0081a46e484f73570c6d58b79 {get; set;}

	public virtual int Prop95d32be11be14d6a8767d6f3ed7d09f8 {get; set;}

	public virtual string Prop622117bc0f1945149c88b2a88b07899f {get; set;}

public static RootClassd80d0d24d0e843edad9d483952bd198e CreateWithRandomData()
{
	var x = new RootClassd80d0d24d0e843edad9d483952bd198e();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propef9d736aa38e4585a5047ad1fa6ebdc6 = RndData.GetString();
	x.Prop8af285098bc34ed3a4be3b2a05cdbc50 = RndData.GetString();
	x.Prop9ce4bc83fb4d425da91b0c78d325c150 = RndData.GetString();
	x.Propd4eb2edb2e604bdfbefb358a8b91f7d3 = RndData.GetString();
	x.Prop41e788ec1c884116b859c64a1048c726 = RndData.GetBool();
	x.Prop05c9735f104a41e59fb8499318a69968 = RndData.GetString();
	x.Prop1b93d1ccb16a4be6b0cd50a5ef54430a = new List<Class50791ff63b0b4d1ba8f72f6e94db59cb>(RndData.GetList(10, Class50791ff63b0b4d1ba8f72f6e94db59cb.CreateWithRandomData));
	x.Prop56575b6efa5d42f5b4caa01290bd8027 = new List<Class89177451ab1d47c58931ac1289279779>(RndData.GetList(10, Class89177451ab1d47c58931ac1289279779.CreateWithRandomData));
	x.Propdb50562ad1bf4254938cf707b8b477cc = RndData.GetInt();
	x.Propf3158a4af866493b82c33eb54fd9fae1 = RndData.GetString();
	x.Propdf5b9bbe39cb43e9bd7868752ed8e1d1 = RndData.GetInt();
	x.Propa786373542744eacb476a6dcb9eb6946 = RndData.GetInt();
	x.Propabf9e73afa9e420da8a811ebfc58f30b = RndData.GetBool();
	x.Propa81c693939e241f4a704733dc54ac97f = RndData.GetInt();
	x.Prop1ea6542e9aca4e9fb710b38d0a0ec604 = RndData.GetBool();
	x.Prop812fd31ab85d40c286cae3444c6396b7 = RndData.GetBool();
	x.Prop9149fed9cffe48d3b0e86926aafbce6b = RndData.GetInt();
	x.Propc3bf106deef940a5a25be16ae89f1510 = RndData.GetInt();
	x.Propb3498cbde4c14662b9cbd21a7e23d212 = new List<Class28efa4143cd34244b347f84c460c6b93>(RndData.GetList(10, Class28efa4143cd34244b347f84c460c6b93.CreateWithRandomData));
	x.Propc7655769465b4fd89e3072309171a7f4 = RndData.GetInt();
	x.Prop578c847ad16046218f3d03c65ba9b739 = RndData.GetInt();
	x.Prop9f09af938bf34a6793aa02e7d3a02614 = RndData.GetBool();
	x.Prop926896c7d9f04c748dfe4bb03fa94556 = RndData.GetInt();
	x.Prop8a0bb435d1d948e7af9dd04f7b916fee = new List<Class4400b92ae3a3422aae70d3ad1c161279>(RndData.GetList(10, Class4400b92ae3a3422aae70d3ad1c161279.CreateWithRandomData));
	x.Propae81199454734e2299282b5179a81a5f = RndData.GetString();
	x.Propa0dbaeb0081a46e484f73570c6d58b79 = RndData.GetString();
	x.Prop95d32be11be14d6a8767d6f3ed7d09f8 = RndData.GetInt();
	x.Prop622117bc0f1945149c88b2a88b07899f = RndData.GetString();
return x;
}
}

public class RootClassc41c96f37df84e61b1eae7cdc09d9003 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop7f943c6494364764a89179958f8bccc4 {get; set;}

	public virtual string Prop2b80260813c048058b33439e9f473840 {get; set;}

	public virtual int Prop3861678520f24053a91a917b5fe2476a {get; set;}

	public virtual int Propf7b996336f3b47aaa4ef3c07f20f169f {get; set;}

	public virtual int Prop87378c138aa84e488d912ac50f632c7b {get; set;}

	public virtual int Prop155fe60b62b241d4bcae89f3271cce5e {get; set;}

	public virtual string Prop4199cbea1f0344f09f5ff3fc60f581b7 {get; set;}

	public virtual string Prop6f8e8a8eafe243de9f4bdb1fa4360127 {get; set;}

	public virtual string Prop0e71cd66eeac45aaaff2c168cec09b44 {get; set;}

	public virtual bool Prop66b558e165294306b38b74f91cbf8472 {get; set;}

	public virtual bool Prop5a01fc4186864b69b0f3f9e5bdc8a7d8 {get; set;}

	public virtual string Propfb474cc9e9d9439c9cc0266555de6c16 {get; set;}

	public virtual int Prop6ca4277a49564b1fabca112cefdd22b5 {get; set;}

	public virtual bool Propf5c2da022d2d402086967e482d91df26 {get; set;}

	public virtual string Prop9a4fed087b3746e7b15286770702d9c0 {get; set;}

	public virtual bool Prop07ce9b7e4719425fad6ca1d37a825c08 {get; set;}

	public virtual string Propfc4a12f0494643289fca26b082b8f099 {get; set;}

	public virtual string Prop5f633820c43c45dfaf36605153555422 {get; set;}

	public virtual bool Propa2803a7e6cac48be9a2b1cea1b5b1a27 {get; set;}

	public virtual string Prop7287308bbfe9442196bc9aaeb21491b3 {get; set;}

	public virtual bool Prop5093fe0df9e14ec29e0e5325d0bb5b58 {get; set;}

public static RootClassc41c96f37df84e61b1eae7cdc09d9003 CreateWithRandomData()
{
	var x = new RootClassc41c96f37df84e61b1eae7cdc09d9003();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop7f943c6494364764a89179958f8bccc4 = RndData.GetBool();
	x.Prop2b80260813c048058b33439e9f473840 = RndData.GetString();
	x.Prop3861678520f24053a91a917b5fe2476a = RndData.GetInt();
	x.Propf7b996336f3b47aaa4ef3c07f20f169f = RndData.GetInt();
	x.Prop87378c138aa84e488d912ac50f632c7b = RndData.GetInt();
	x.Prop155fe60b62b241d4bcae89f3271cce5e = RndData.GetInt();
	x.Prop4199cbea1f0344f09f5ff3fc60f581b7 = RndData.GetString();
	x.Prop6f8e8a8eafe243de9f4bdb1fa4360127 = RndData.GetString();
	x.Prop0e71cd66eeac45aaaff2c168cec09b44 = RndData.GetString();
	x.Prop66b558e165294306b38b74f91cbf8472 = RndData.GetBool();
	x.Prop5a01fc4186864b69b0f3f9e5bdc8a7d8 = RndData.GetBool();
	x.Propfb474cc9e9d9439c9cc0266555de6c16 = RndData.GetString();
	x.Prop6ca4277a49564b1fabca112cefdd22b5 = RndData.GetInt();
	x.Propf5c2da022d2d402086967e482d91df26 = RndData.GetBool();
	x.Prop9a4fed087b3746e7b15286770702d9c0 = RndData.GetString();
	x.Prop07ce9b7e4719425fad6ca1d37a825c08 = RndData.GetBool();
	x.Propfc4a12f0494643289fca26b082b8f099 = RndData.GetString();
	x.Prop5f633820c43c45dfaf36605153555422 = RndData.GetString();
	x.Propa2803a7e6cac48be9a2b1cea1b5b1a27 = RndData.GetBool();
	x.Prop7287308bbfe9442196bc9aaeb21491b3 = RndData.GetString();
	x.Prop5093fe0df9e14ec29e0e5325d0bb5b58 = RndData.GetBool();
return x;
}
}

public class RootClassf348e5fde7ca4d2f8e5b00d2ab139525 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propfbc419f8383f4c71a9dcbe8d8c398ab9 {get; set;}

	public virtual bool Prop62ecd565b1fd40ba8717aa6dcbae45f7 {get; set;}

	public virtual string Propb68124b099e3400fbf2ca49298bc000f {get; set;}

	public virtual string Prop4808b4cf75db4cc2bcbac47b68fdc30f {get; set;}

	public virtual string Prop7070f64a98a84401b7135a2a3f434c79 {get; set;}

	public virtual bool Prop22c217f832484a8a90e9f8308696c7d3 {get; set;}

	public virtual bool Prop2e3df81dad0a40458873305d032fe1e5 {get; set;}

	public virtual int Prop47d3ba5da57b42308cc68a5f417a9686 {get; set;}

	public virtual int Prop0e83cdbb673446a99dcb703052e43e19 {get; set;}

	public virtual string Prop9c4ad7821b5445f0aa02cf6324ae2cd8 {get; set;}

	public virtual string Prop5747b47299314072b64154af72e4fe13 {get; set;}

	public virtual int Propc341647c44c24acd9cf63eb7cba60842 {get; set;}

	public virtual Class9e69c8c79443439a9aa3abac37dd6d87 Propfd5095a786234f0fb66899ea060669b3 {get; set;}

	public virtual bool Prop7c5d7ea631dc4377928e8d6506a32ba6 {get; set;}

	public virtual int Propc7e70f87a3c749a7bedc5701db6fc09a {get; set;}

	public virtual int Prop1b9044b4591b46c986ce1cc53c976d75 {get; set;}

	public virtual int Prop02e97f2b06394e8c9649db34aa6792aa {get; set;}

	public virtual bool Propb7613ad1379949259e293a03de8d6165 {get; set;}

	public virtual string Prop190b12eef2104432ace6296909a27bca {get; set;}

	public virtual string Prop4ef9bc84f52c419a9557e868d124c0ac {get; set;}

public static RootClassf348e5fde7ca4d2f8e5b00d2ab139525 CreateWithRandomData()
{
	var x = new RootClassf348e5fde7ca4d2f8e5b00d2ab139525();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propfbc419f8383f4c71a9dcbe8d8c398ab9 = RndData.GetInt();
	x.Prop62ecd565b1fd40ba8717aa6dcbae45f7 = RndData.GetBool();
	x.Propb68124b099e3400fbf2ca49298bc000f = RndData.GetString();
	x.Prop4808b4cf75db4cc2bcbac47b68fdc30f = RndData.GetString();
	x.Prop7070f64a98a84401b7135a2a3f434c79 = RndData.GetString();
	x.Prop22c217f832484a8a90e9f8308696c7d3 = RndData.GetBool();
	x.Prop2e3df81dad0a40458873305d032fe1e5 = RndData.GetBool();
	x.Prop47d3ba5da57b42308cc68a5f417a9686 = RndData.GetInt();
	x.Prop0e83cdbb673446a99dcb703052e43e19 = RndData.GetInt();
	x.Prop9c4ad7821b5445f0aa02cf6324ae2cd8 = RndData.GetString();
	x.Prop5747b47299314072b64154af72e4fe13 = RndData.GetString();
	x.Propc341647c44c24acd9cf63eb7cba60842 = RndData.GetInt();
	x.Propfd5095a786234f0fb66899ea060669b3 = Class9e69c8c79443439a9aa3abac37dd6d87.CreateWithRandomData();
	x.Prop7c5d7ea631dc4377928e8d6506a32ba6 = RndData.GetBool();
	x.Propc7e70f87a3c749a7bedc5701db6fc09a = RndData.GetInt();
	x.Prop1b9044b4591b46c986ce1cc53c976d75 = RndData.GetInt();
	x.Prop02e97f2b06394e8c9649db34aa6792aa = RndData.GetInt();
	x.Propb7613ad1379949259e293a03de8d6165 = RndData.GetBool();
	x.Prop190b12eef2104432ace6296909a27bca = RndData.GetString();
	x.Prop4ef9bc84f52c419a9557e868d124c0ac = RndData.GetString();
return x;
}
}

public class Class52fae3543824470ca336f0e2bd1bbca2 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop699f6a6aaee54f9fb6876dfc660ddf66 {get; set;}

	public virtual string Prop46b8aaaabcd64f60b5aa75c83086ce58 {get; set;}

	public virtual bool Prop685b46468ff34ad882a5f2cd15dbdb79 {get; set;}

	public virtual bool Prop3ac006f7d1d54ca1983b965bed0c15c7 {get; set;}

	public virtual string Prop329d4f58d75e4838843736b9d867e1ca {get; set;}

	public virtual string Prop6fe97e55676a4a0aadcf0b69240fd94c {get; set;}

	public virtual string Prop85704f934b9c459aa7ef0032d39099d1 {get; set;}

	public virtual int Propcde078af054d46d58517d9c693891ed9 {get; set;}

	public virtual string Prop99b9a1b3b44742198a237c39391c655a {get; set;}

	public virtual int Propf19bd332ee85418ab5f063d5f1f62833 {get; set;}

	public virtual int Propd1ac964e754647d188b96c910bfd75b0 {get; set;}

	public virtual bool Prop1aefa2817f284558a15211d3c1e6bfc4 {get; set;}

	public virtual string Prop491d24ab838145e397890dc04ce4b0ec {get; set;}

	public virtual ICollection<Class2dabfec589ca4b6b9d16c051281f202b> Prop63c44c4fcb95407389455e4c636f6f4a {get; set;}

	public virtual string Propb0e361e78c72442daa1a30dcbeefb266 {get; set;}

	public virtual bool Propb35ca1a8a2864be4bfe1752a91d4f000 {get; set;}

	public virtual int Prope1a8e97a8ee54054b6968241ba98d50c {get; set;}

	public virtual bool Prop26b1632133ec42d5a4d735132814a3b6 {get; set;}

	public virtual string Prop2da9cb7716874dc6888a8e8597ed8a4e {get; set;}

	public virtual bool Prop467e14b8158842f8b7b31bf3f22f9751 {get; set;}

	public virtual int Propac556a541e8f4e45bbc24c14330b24e6 {get; set;}

	public virtual string Prop5ebc595c886c41a6a8790136d8782565 {get; set;}

	public virtual ICollection<Class93274669679e498fb84cff36cbf7fbc9> Prop8feae4e20f9542548fbdfdc0b353988d {get; set;}

	public virtual Classac2d0e999d6c472cad347a531220dea5 Propfea555d45a19479ca09aa63af18fa0aa {get; set;}

	public virtual string Prop0d098161db8e4abf965dd5449337f59d {get; set;}

	public virtual string Propff4a085eb36248158f264c76c7331408 {get; set;}

	public virtual bool Prop007ea5bfaa4d4af99d864d96f8258c06 {get; set;}

	public virtual int Propf84130e5386a45759f363e46d041a13b {get; set;}

	public virtual int Propc00e4e43c1c844eebcf28cace1112261 {get; set;}

public static Class52fae3543824470ca336f0e2bd1bbca2 CreateWithRandomData()
{
	var x = new Class52fae3543824470ca336f0e2bd1bbca2();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop699f6a6aaee54f9fb6876dfc660ddf66 = RndData.GetBool();
	x.Prop46b8aaaabcd64f60b5aa75c83086ce58 = RndData.GetString();
	x.Prop685b46468ff34ad882a5f2cd15dbdb79 = RndData.GetBool();
	x.Prop3ac006f7d1d54ca1983b965bed0c15c7 = RndData.GetBool();
	x.Prop329d4f58d75e4838843736b9d867e1ca = RndData.GetString();
	x.Prop6fe97e55676a4a0aadcf0b69240fd94c = RndData.GetString();
	x.Prop85704f934b9c459aa7ef0032d39099d1 = RndData.GetString();
	x.Propcde078af054d46d58517d9c693891ed9 = RndData.GetInt();
	x.Prop99b9a1b3b44742198a237c39391c655a = RndData.GetString();
	x.Propf19bd332ee85418ab5f063d5f1f62833 = RndData.GetInt();
	x.Propd1ac964e754647d188b96c910bfd75b0 = RndData.GetInt();
	x.Prop1aefa2817f284558a15211d3c1e6bfc4 = RndData.GetBool();
	x.Prop491d24ab838145e397890dc04ce4b0ec = RndData.GetString();
	x.Prop63c44c4fcb95407389455e4c636f6f4a = new List<Class2dabfec589ca4b6b9d16c051281f202b>(RndData.GetList(10, Class2dabfec589ca4b6b9d16c051281f202b.CreateWithRandomData));
	x.Propb0e361e78c72442daa1a30dcbeefb266 = RndData.GetString();
	x.Propb35ca1a8a2864be4bfe1752a91d4f000 = RndData.GetBool();
	x.Prope1a8e97a8ee54054b6968241ba98d50c = RndData.GetInt();
	x.Prop26b1632133ec42d5a4d735132814a3b6 = RndData.GetBool();
	x.Prop2da9cb7716874dc6888a8e8597ed8a4e = RndData.GetString();
	x.Prop467e14b8158842f8b7b31bf3f22f9751 = RndData.GetBool();
	x.Propac556a541e8f4e45bbc24c14330b24e6 = RndData.GetInt();
	x.Prop5ebc595c886c41a6a8790136d8782565 = RndData.GetString();
	x.Prop8feae4e20f9542548fbdfdc0b353988d = new List<Class93274669679e498fb84cff36cbf7fbc9>(RndData.GetList(10, Class93274669679e498fb84cff36cbf7fbc9.CreateWithRandomData));
	x.Propfea555d45a19479ca09aa63af18fa0aa = Classac2d0e999d6c472cad347a531220dea5.CreateWithRandomData();
	x.Prop0d098161db8e4abf965dd5449337f59d = RndData.GetString();
	x.Propff4a085eb36248158f264c76c7331408 = RndData.GetString();
	x.Prop007ea5bfaa4d4af99d864d96f8258c06 = RndData.GetBool();
	x.Propf84130e5386a45759f363e46d041a13b = RndData.GetInt();
	x.Propc00e4e43c1c844eebcf28cace1112261 = RndData.GetInt();
return x;
}
}

public class Class2dabfec589ca4b6b9d16c051281f202b : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop9b3f1cf21c4c4fa4824f0710ec7deaf4 {get; set;}

	public virtual bool Prop8f17c7b8d4ab470b8f4b7628c6c3030c {get; set;}

	public virtual bool Prop84229c37041d478b93dfb72cbd696a28 {get; set;}

	public virtual int Prop206157b9258841349924d9df70f40b47 {get; set;}

	public virtual bool Prope449892e9faf42a5a449a2db919395b2 {get; set;}

	public virtual bool Prop2600c4de57a744daa70d64af723e2663 {get; set;}

	public virtual string Prop238923b741234730ab5a484a023a6a3a {get; set;}

	public virtual int Prop5a1cbb0f08f94230bf44e0ab8bf0fa5e {get; set;}

	public virtual int Prop9ead2c58f63b4c31b7ae6011dcc43b7f {get; set;}

	public virtual bool Prop48efe7c2526b4ab2b37d38f74a868e52 {get; set;}

	public virtual ICollection<Class68a69474966b4b95add5b46c1f761956> Prop38287b75695640f79ede7d7ce3d9dd9e {get; set;}

	public virtual bool Propa2c7c0f906b345c28b52b8d6f12ff1e4 {get; set;}

	public virtual string Propcf316ec60cfc4901aee4f183396dbd80 {get; set;}

	public virtual string Prop79000c0f8dac470bbe40508818ec3381 {get; set;}

	public virtual string Propda2acd69715a4453a9e1c42a23d733fa {get; set;}

	public virtual int Propbacbf332ea134358aa3b0b024a06a815 {get; set;}

	public virtual string Propff8005f92bc74f809a6538fab4a2c1e5 {get; set;}

	public virtual bool Propbceaef71ac5e4cd788ffd35b551e28bd {get; set;}

	public virtual bool Prop53041ac1a3b54603b3f4962aab73901e {get; set;}

public static Class2dabfec589ca4b6b9d16c051281f202b CreateWithRandomData()
{
	var x = new Class2dabfec589ca4b6b9d16c051281f202b();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop9b3f1cf21c4c4fa4824f0710ec7deaf4 = RndData.GetInt();
	x.Prop8f17c7b8d4ab470b8f4b7628c6c3030c = RndData.GetBool();
	x.Prop84229c37041d478b93dfb72cbd696a28 = RndData.GetBool();
	x.Prop206157b9258841349924d9df70f40b47 = RndData.GetInt();
	x.Prope449892e9faf42a5a449a2db919395b2 = RndData.GetBool();
	x.Prop2600c4de57a744daa70d64af723e2663 = RndData.GetBool();
	x.Prop238923b741234730ab5a484a023a6a3a = RndData.GetString();
	x.Prop5a1cbb0f08f94230bf44e0ab8bf0fa5e = RndData.GetInt();
	x.Prop9ead2c58f63b4c31b7ae6011dcc43b7f = RndData.GetInt();
	x.Prop48efe7c2526b4ab2b37d38f74a868e52 = RndData.GetBool();
	x.Prop38287b75695640f79ede7d7ce3d9dd9e = new List<Class68a69474966b4b95add5b46c1f761956>(RndData.GetList(10, Class68a69474966b4b95add5b46c1f761956.CreateWithRandomData));
	x.Propa2c7c0f906b345c28b52b8d6f12ff1e4 = RndData.GetBool();
	x.Propcf316ec60cfc4901aee4f183396dbd80 = RndData.GetString();
	x.Prop79000c0f8dac470bbe40508818ec3381 = RndData.GetString();
	x.Propda2acd69715a4453a9e1c42a23d733fa = RndData.GetString();
	x.Propbacbf332ea134358aa3b0b024a06a815 = RndData.GetInt();
	x.Propff8005f92bc74f809a6538fab4a2c1e5 = RndData.GetString();
	x.Propbceaef71ac5e4cd788ffd35b551e28bd = RndData.GetBool();
	x.Prop53041ac1a3b54603b3f4962aab73901e = RndData.GetBool();
return x;
}
}

public class Class68a69474966b4b95add5b46c1f761956 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop1812f7fd28d54009ad543d7b997f57c9 {get; set;}

	public virtual string Propa9e9789e23474df583fa197339655332 {get; set;}

	public virtual int Prop9997ade8b41a45419a09dc57ef3bae86 {get; set;}

	public virtual string Prop8058328805474495ad1a41a93cc37818 {get; set;}

	public virtual string Propf7922f4db0ff4ce891672eefeb1a4eef {get; set;}

	public virtual int Prop334cd5b4d5904220b0321b5545622dda {get; set;}

	public virtual int Propbc38685e2f1149d3bca19e84eab50c5d {get; set;}

	public virtual int Prop13f680760fe542b9be120e1dce567814 {get; set;}

	public virtual bool Prop4d43fdbd14ea42a7997583cc868d4160 {get; set;}

	public virtual int Prop30666944e54046b69d2e0108cbc6c5f8 {get; set;}

	public virtual bool Prop3683826426d24d5cad4399a913458223 {get; set;}

	public virtual int Propabd9e1b735dd414dbc01cf3046962333 {get; set;}

	public virtual string Prop7d1c8c2e799f4701abe31bb3f10b4006 {get; set;}

	public virtual bool Prope3c386c8958f443db24278ecd87635a3 {get; set;}

	public virtual bool Prop6a0fa1c801b04af0b775a0cbce91b414 {get; set;}

	public virtual bool Prop3c1026ae0df242e094519d7a57871292 {get; set;}

	public virtual bool Propa76d192e5fc7483e924cfcd1fec572e5 {get; set;}

	public virtual int Propf5df4be50e7c481092b1407192aa7b5f {get; set;}

	public virtual string Prop278daeeb4f3a400481785c1daa2262f7 {get; set;}

	public virtual string Propb41b5961815449739b0dc98bb59a4423 {get; set;}

	public virtual string Prop75d5a7ae53f24717adbf96218cc6eb03 {get; set;}

	public virtual string Prop6f8acc7ea7614464b4f94ebde8c6b586 {get; set;}

	public virtual string Prop4c2d8969fa444ac487e36fec4261ab98 {get; set;}

	public virtual bool Prop936184e01c074bc2a06ea7b4566f3336 {get; set;}

public static Class68a69474966b4b95add5b46c1f761956 CreateWithRandomData()
{
	var x = new Class68a69474966b4b95add5b46c1f761956();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop1812f7fd28d54009ad543d7b997f57c9 = RndData.GetString();
	x.Propa9e9789e23474df583fa197339655332 = RndData.GetString();
	x.Prop9997ade8b41a45419a09dc57ef3bae86 = RndData.GetInt();
	x.Prop8058328805474495ad1a41a93cc37818 = RndData.GetString();
	x.Propf7922f4db0ff4ce891672eefeb1a4eef = RndData.GetString();
	x.Prop334cd5b4d5904220b0321b5545622dda = RndData.GetInt();
	x.Propbc38685e2f1149d3bca19e84eab50c5d = RndData.GetInt();
	x.Prop13f680760fe542b9be120e1dce567814 = RndData.GetInt();
	x.Prop4d43fdbd14ea42a7997583cc868d4160 = RndData.GetBool();
	x.Prop30666944e54046b69d2e0108cbc6c5f8 = RndData.GetInt();
	x.Prop3683826426d24d5cad4399a913458223 = RndData.GetBool();
	x.Propabd9e1b735dd414dbc01cf3046962333 = RndData.GetInt();
	x.Prop7d1c8c2e799f4701abe31bb3f10b4006 = RndData.GetString();
	x.Prope3c386c8958f443db24278ecd87635a3 = RndData.GetBool();
	x.Prop6a0fa1c801b04af0b775a0cbce91b414 = RndData.GetBool();
	x.Prop3c1026ae0df242e094519d7a57871292 = RndData.GetBool();
	x.Propa76d192e5fc7483e924cfcd1fec572e5 = RndData.GetBool();
	x.Propf5df4be50e7c481092b1407192aa7b5f = RndData.GetInt();
	x.Prop278daeeb4f3a400481785c1daa2262f7 = RndData.GetString();
	x.Propb41b5961815449739b0dc98bb59a4423 = RndData.GetString();
	x.Prop75d5a7ae53f24717adbf96218cc6eb03 = RndData.GetString();
	x.Prop6f8acc7ea7614464b4f94ebde8c6b586 = RndData.GetString();
	x.Prop4c2d8969fa444ac487e36fec4261ab98 = RndData.GetString();
	x.Prop936184e01c074bc2a06ea7b4566f3336 = RndData.GetBool();
return x;
}
}

public class Class93274669679e498fb84cff36cbf7fbc9 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Propd7411bfebaf04d4cacdbff16d3d3e749 {get; set;}

	public virtual bool Prop19aa02326d5e4599a5380b486575d4dc {get; set;}

	public virtual bool Propa672adb05f8f405ca136d724a2da8a46 {get; set;}

	public virtual int Prop87d8d808a17f4eedaf36b850142700b9 {get; set;}

	public virtual int Propa105b749828849768a4a11681c29364f {get; set;}

	public virtual int Prop540b13a86bc64a918314d0236287a4af {get; set;}

	public virtual bool Prop820349a7ae41420298def3b3110b2fc6 {get; set;}

	public virtual int Propf3527103fefa483094de3d9a40844634 {get; set;}

	public virtual bool Propb12396bf50384a97971828dbc5f5308b {get; set;}

	public virtual bool Prop20f0613808814364bac6895fa26087d7 {get; set;}

	public virtual string Propd2eb852859424937bf4d92cb78f2a1a2 {get; set;}

	public virtual string Prop0166c454792448729c0177fa7410442f {get; set;}

	public virtual string Prop008ea3fc077f4dcdb99ca1566ed12b1e {get; set;}

	public virtual string Propfccdab8f41bc4885912d858f2c434afc {get; set;}

	public virtual bool Prop2091da7ab51d4013848a96c8d00c8265 {get; set;}

public static Class93274669679e498fb84cff36cbf7fbc9 CreateWithRandomData()
{
	var x = new Class93274669679e498fb84cff36cbf7fbc9();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propd7411bfebaf04d4cacdbff16d3d3e749 = RndData.GetBool();
	x.Prop19aa02326d5e4599a5380b486575d4dc = RndData.GetBool();
	x.Propa672adb05f8f405ca136d724a2da8a46 = RndData.GetBool();
	x.Prop87d8d808a17f4eedaf36b850142700b9 = RndData.GetInt();
	x.Propa105b749828849768a4a11681c29364f = RndData.GetInt();
	x.Prop540b13a86bc64a918314d0236287a4af = RndData.GetInt();
	x.Prop820349a7ae41420298def3b3110b2fc6 = RndData.GetBool();
	x.Propf3527103fefa483094de3d9a40844634 = RndData.GetInt();
	x.Propb12396bf50384a97971828dbc5f5308b = RndData.GetBool();
	x.Prop20f0613808814364bac6895fa26087d7 = RndData.GetBool();
	x.Propd2eb852859424937bf4d92cb78f2a1a2 = RndData.GetString();
	x.Prop0166c454792448729c0177fa7410442f = RndData.GetString();
	x.Prop008ea3fc077f4dcdb99ca1566ed12b1e = RndData.GetString();
	x.Propfccdab8f41bc4885912d858f2c434afc = RndData.GetString();
	x.Prop2091da7ab51d4013848a96c8d00c8265 = RndData.GetBool();
return x;
}
}

public class Classac2d0e999d6c472cad347a531220dea5 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop06f8850206d740819f2453924ca41a31 {get; set;}

	public virtual int Propbf7883b683b74941aeda3ab68780f65f {get; set;}

	public virtual Classfd4554df40b74fb18c70e350c3266cd8 Prop14f8f368ddd64525974eea1495d39f51 {get; set;}

	public virtual int Propc276806c973d420ba0f7fa3da92ece1d {get; set;}

	public virtual bool Propfd71776c22344235a6e0a33b48c08354 {get; set;}

	public virtual bool Prop1d48db6c30e7429497944b05c761ae06 {get; set;}

	public virtual bool Propef2661b27bd94e2dae61b8a10206dd2d {get; set;}

	public virtual string Propb3e1998c62eb4644ab41ce726c4d4863 {get; set;}

	public virtual bool Prop090565022dfb4c53893f5879ffdf03a3 {get; set;}

	public virtual string Prop83316112895a46ccae7984d942c15ccd {get; set;}

	public virtual string Propfcb511f0831643229c9efdd913277898 {get; set;}

public static Classac2d0e999d6c472cad347a531220dea5 CreateWithRandomData()
{
	var x = new Classac2d0e999d6c472cad347a531220dea5();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop06f8850206d740819f2453924ca41a31 = RndData.GetString();
	x.Propbf7883b683b74941aeda3ab68780f65f = RndData.GetInt();
	x.Prop14f8f368ddd64525974eea1495d39f51 = Classfd4554df40b74fb18c70e350c3266cd8.CreateWithRandomData();
	x.Propc276806c973d420ba0f7fa3da92ece1d = RndData.GetInt();
	x.Propfd71776c22344235a6e0a33b48c08354 = RndData.GetBool();
	x.Prop1d48db6c30e7429497944b05c761ae06 = RndData.GetBool();
	x.Propef2661b27bd94e2dae61b8a10206dd2d = RndData.GetBool();
	x.Propb3e1998c62eb4644ab41ce726c4d4863 = RndData.GetString();
	x.Prop090565022dfb4c53893f5879ffdf03a3 = RndData.GetBool();
	x.Prop83316112895a46ccae7984d942c15ccd = RndData.GetString();
	x.Propfcb511f0831643229c9efdd913277898 = RndData.GetString();
return x;
}
}

public class Classfd4554df40b74fb18c70e350c3266cd8 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop3389c0b533484cc7905b001cac982417 {get; set;}

	public virtual string Prop7184d30c5620471c8da3ebd614b38057 {get; set;}

	public virtual int Prop28957ad4821a467fb5349576e14f07f5 {get; set;}

	public virtual bool Propb5a789c268304c09a44e7cfd5a20bc9c {get; set;}

	public virtual bool Prop6099d47fccab49d9a8c768e504cc3c2d {get; set;}

	public virtual string Propf0b568487c1c4d30bc37a07ecfebc55f {get; set;}

	public virtual bool Propb2768aece72e45a6b2e579accc6644c1 {get; set;}

	public virtual int Prop394ae96491644af9b849d42ce642f7e8 {get; set;}

	public virtual int Prop7375c61fd0324457a60ed0f8dccb631c {get; set;}

	public virtual string Propf89c89947eaf40bc80484fcb6c49cd1f {get; set;}

	public virtual string Prop18d881923f38414c81a03fdcde211d58 {get; set;}

	public virtual string Prop15608256b400446695ed0d2451767524 {get; set;}

	public virtual bool Prop53d4adf7892c46dfa21528b2fa8b1ea7 {get; set;}

	public virtual string Prop505839a121494c719fd962158ac65e93 {get; set;}

	public virtual string Propd38ed54bfc1e4f1cb3d81672c6559ae5 {get; set;}

	public virtual string Prop475d0f0b98ff4efdac6bd35fd21ac3cf {get; set;}

	public virtual string Propba979c4727c1432dbab49d32ca9deb1f {get; set;}

	public virtual string Prop105fe7d0d3cf45228f52a38e62169b69 {get; set;}

	public virtual int Prop0e8b5613e6ed4e15a184c59216100ada {get; set;}

	public virtual string Prop0d418a36c2664a668e31caab4298a007 {get; set;}

	public virtual int Prop51c4986595054585805697300c4dd589 {get; set;}

	public virtual bool Propd6ca77933cfa42ce9171f97ac65e05d5 {get; set;}

	public virtual string Prop8ea5e3b9c0464f899f554254060214e4 {get; set;}

public static Classfd4554df40b74fb18c70e350c3266cd8 CreateWithRandomData()
{
	var x = new Classfd4554df40b74fb18c70e350c3266cd8();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop3389c0b533484cc7905b001cac982417 = RndData.GetBool();
	x.Prop7184d30c5620471c8da3ebd614b38057 = RndData.GetString();
	x.Prop28957ad4821a467fb5349576e14f07f5 = RndData.GetInt();
	x.Propb5a789c268304c09a44e7cfd5a20bc9c = RndData.GetBool();
	x.Prop6099d47fccab49d9a8c768e504cc3c2d = RndData.GetBool();
	x.Propf0b568487c1c4d30bc37a07ecfebc55f = RndData.GetString();
	x.Propb2768aece72e45a6b2e579accc6644c1 = RndData.GetBool();
	x.Prop394ae96491644af9b849d42ce642f7e8 = RndData.GetInt();
	x.Prop7375c61fd0324457a60ed0f8dccb631c = RndData.GetInt();
	x.Propf89c89947eaf40bc80484fcb6c49cd1f = RndData.GetString();
	x.Prop18d881923f38414c81a03fdcde211d58 = RndData.GetString();
	x.Prop15608256b400446695ed0d2451767524 = RndData.GetString();
	x.Prop53d4adf7892c46dfa21528b2fa8b1ea7 = RndData.GetBool();
	x.Prop505839a121494c719fd962158ac65e93 = RndData.GetString();
	x.Propd38ed54bfc1e4f1cb3d81672c6559ae5 = RndData.GetString();
	x.Prop475d0f0b98ff4efdac6bd35fd21ac3cf = RndData.GetString();
	x.Propba979c4727c1432dbab49d32ca9deb1f = RndData.GetString();
	x.Prop105fe7d0d3cf45228f52a38e62169b69 = RndData.GetString();
	x.Prop0e8b5613e6ed4e15a184c59216100ada = RndData.GetInt();
	x.Prop0d418a36c2664a668e31caab4298a007 = RndData.GetString();
	x.Prop51c4986595054585805697300c4dd589 = RndData.GetInt();
	x.Propd6ca77933cfa42ce9171f97ac65e05d5 = RndData.GetBool();
	x.Prop8ea5e3b9c0464f899f554254060214e4 = RndData.GetString();
return x;
}
}

public class Class8ddc74736e4340929c62b7cd5d01882c : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propa78df870bf8242639cd565becb0debaf {get; set;}

	public virtual int Prop65d50db564694b05a40b66f3a39a8526 {get; set;}

	public virtual int Propb58ef48b86704334841ba1c008002721 {get; set;}

	public virtual string Prop52a4ba6c8d5b4d7cbde27be8cb73e1c2 {get; set;}

	public virtual string Prop23b3e9be37ff40fa8c2b689f03e8195b {get; set;}

	public virtual int Prop1d13a4a651e6455e8fdf0267ffc25191 {get; set;}

	public virtual bool Prop1eb6e06d73404c14b78f64da54b231e2 {get; set;}

	public virtual bool Prop8ac5195b7ed448149ad9642540772530 {get; set;}

	public virtual ICollection<Class6b0fd8a7d91045b8a637b22026bf0583> Propf04f7bc22bb0428588100e5d3ea3e5e0 {get; set;}

	public virtual bool Prop78c1d2176e21472bb89a94b1da7dc991 {get; set;}

	public virtual Classf9e243f8d1494e69be6b959fc813c2a2 Propb2fd4b3a28854ab4b9495b167039470e {get; set;}

	public virtual ICollection<Classab66337c42bc47f6873e2752f8c9e34f> Propad583ffb59514997b82b0d886b3af316 {get; set;}

	public virtual bool Prope9586f8240734bbab06b84cbe62489b6 {get; set;}

	public virtual int Propdd5c8cb1eb154bc8af1e276508da387b {get; set;}

	public virtual string Propf910e78a919d45b094ed1f07176b2f0e {get; set;}

	public virtual string Propea7c68a5824c491685da80821e3ef9ad {get; set;}

public static Class8ddc74736e4340929c62b7cd5d01882c CreateWithRandomData()
{
	var x = new Class8ddc74736e4340929c62b7cd5d01882c();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propa78df870bf8242639cd565becb0debaf = RndData.GetInt();
	x.Prop65d50db564694b05a40b66f3a39a8526 = RndData.GetInt();
	x.Propb58ef48b86704334841ba1c008002721 = RndData.GetInt();
	x.Prop52a4ba6c8d5b4d7cbde27be8cb73e1c2 = RndData.GetString();
	x.Prop23b3e9be37ff40fa8c2b689f03e8195b = RndData.GetString();
	x.Prop1d13a4a651e6455e8fdf0267ffc25191 = RndData.GetInt();
	x.Prop1eb6e06d73404c14b78f64da54b231e2 = RndData.GetBool();
	x.Prop8ac5195b7ed448149ad9642540772530 = RndData.GetBool();
	x.Propf04f7bc22bb0428588100e5d3ea3e5e0 = new List<Class6b0fd8a7d91045b8a637b22026bf0583>(RndData.GetList(10, Class6b0fd8a7d91045b8a637b22026bf0583.CreateWithRandomData));
	x.Prop78c1d2176e21472bb89a94b1da7dc991 = RndData.GetBool();
	x.Propb2fd4b3a28854ab4b9495b167039470e = Classf9e243f8d1494e69be6b959fc813c2a2.CreateWithRandomData();
	x.Propad583ffb59514997b82b0d886b3af316 = new List<Classab66337c42bc47f6873e2752f8c9e34f>(RndData.GetList(10, Classab66337c42bc47f6873e2752f8c9e34f.CreateWithRandomData));
	x.Prope9586f8240734bbab06b84cbe62489b6 = RndData.GetBool();
	x.Propdd5c8cb1eb154bc8af1e276508da387b = RndData.GetInt();
	x.Propf910e78a919d45b094ed1f07176b2f0e = RndData.GetString();
	x.Propea7c68a5824c491685da80821e3ef9ad = RndData.GetString();
return x;
}
}

public class Class6b0fd8a7d91045b8a637b22026bf0583 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop8403ee06a1b44e17913c6622b65f9788 {get; set;}

	public virtual Class8cc3c55900ec4b6cb7e3d21dcb2f7aae Prop4a35c0972ad0485abc47b09b6f7bd291 {get; set;}

	public virtual int Prop593c4e3160a847bdb548ccea33584375 {get; set;}

	public virtual string Prop74a0d7b008f64f61b04aecef1980c795 {get; set;}

	public virtual int Propbf9aa3247c71400e91551db2d3cc350f {get; set;}

	public virtual bool Propfb5649d1421749dc827966eab30061fb {get; set;}

	public virtual int Prop89f8754b51ae4b8580eee048e12e14ed {get; set;}

	public virtual string Prop128d23ef7fe7469ab9c6ac7018842909 {get; set;}

	public virtual int Prop3c352df1ce4145dd96552c2501c79c84 {get; set;}

	public virtual bool Prop87ee81d187a048f9ae52164992922f52 {get; set;}

	public virtual int Propa306ca9b149747f9993bc72d58435cbe {get; set;}

	public virtual int Prop4ec40f9c18c84927afb763a4373d7cf0 {get; set;}

	public virtual string Propb7de39502209402abf5d44d4accacb3b {get; set;}

	public virtual string Prop45746b1313af44489d0bd0b68d094196 {get; set;}

	public virtual int Prop78fb40a98c684408bdc4139d9f046ff5 {get; set;}

	public virtual string Prop308e5a9e15a6497dbc1008d6bebfc2c9 {get; set;}

	public virtual string Propd0fcac5060944cb1aed7ee7799e9c3bc {get; set;}

	public virtual int Prop0b1d3f09bf5d47d3b2ded77c098ca176 {get; set;}

	public virtual string Prop96ed0886c8714cd68a67a07c42307eac {get; set;}

	public virtual bool Prop97c15a8053b4418290dd76c618d17791 {get; set;}

	public virtual string Propbb52cd3bc8584f20afa4c3ecbea4a8c8 {get; set;}

	public virtual string Prop7ed790075c524033ad656400aa709b4b {get; set;}

	public virtual bool Prop597a53b88a2641129a7fadf781e56eba {get; set;}

	public virtual bool Propf66f414832cb41aaac5ba3f4dccbd938 {get; set;}

	public virtual bool Prop9d7cd93cd34f443fac470103310c7ec3 {get; set;}

	public virtual bool Prop73fc141310fc440b9f9d45851505c0e3 {get; set;}

	public virtual Class9e78866c3b954c26a00deef1c7900550 Prop947e578e582a4841a41823ca03b76a38 {get; set;}

	public virtual ICollection<Class392a7b6ce9f64a41a208778aa5c3e347> Propbe5f154d0e05458c9d7ce453640277f7 {get; set;}

public static Class6b0fd8a7d91045b8a637b22026bf0583 CreateWithRandomData()
{
	var x = new Class6b0fd8a7d91045b8a637b22026bf0583();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop8403ee06a1b44e17913c6622b65f9788 = RndData.GetBool();
	x.Prop4a35c0972ad0485abc47b09b6f7bd291 = Class8cc3c55900ec4b6cb7e3d21dcb2f7aae.CreateWithRandomData();
	x.Prop593c4e3160a847bdb548ccea33584375 = RndData.GetInt();
	x.Prop74a0d7b008f64f61b04aecef1980c795 = RndData.GetString();
	x.Propbf9aa3247c71400e91551db2d3cc350f = RndData.GetInt();
	x.Propfb5649d1421749dc827966eab30061fb = RndData.GetBool();
	x.Prop89f8754b51ae4b8580eee048e12e14ed = RndData.GetInt();
	x.Prop128d23ef7fe7469ab9c6ac7018842909 = RndData.GetString();
	x.Prop3c352df1ce4145dd96552c2501c79c84 = RndData.GetInt();
	x.Prop87ee81d187a048f9ae52164992922f52 = RndData.GetBool();
	x.Propa306ca9b149747f9993bc72d58435cbe = RndData.GetInt();
	x.Prop4ec40f9c18c84927afb763a4373d7cf0 = RndData.GetInt();
	x.Propb7de39502209402abf5d44d4accacb3b = RndData.GetString();
	x.Prop45746b1313af44489d0bd0b68d094196 = RndData.GetString();
	x.Prop78fb40a98c684408bdc4139d9f046ff5 = RndData.GetInt();
	x.Prop308e5a9e15a6497dbc1008d6bebfc2c9 = RndData.GetString();
	x.Propd0fcac5060944cb1aed7ee7799e9c3bc = RndData.GetString();
	x.Prop0b1d3f09bf5d47d3b2ded77c098ca176 = RndData.GetInt();
	x.Prop96ed0886c8714cd68a67a07c42307eac = RndData.GetString();
	x.Prop97c15a8053b4418290dd76c618d17791 = RndData.GetBool();
	x.Propbb52cd3bc8584f20afa4c3ecbea4a8c8 = RndData.GetString();
	x.Prop7ed790075c524033ad656400aa709b4b = RndData.GetString();
	x.Prop597a53b88a2641129a7fadf781e56eba = RndData.GetBool();
	x.Propf66f414832cb41aaac5ba3f4dccbd938 = RndData.GetBool();
	x.Prop9d7cd93cd34f443fac470103310c7ec3 = RndData.GetBool();
	x.Prop73fc141310fc440b9f9d45851505c0e3 = RndData.GetBool();
	x.Prop947e578e582a4841a41823ca03b76a38 = Class9e78866c3b954c26a00deef1c7900550.CreateWithRandomData();
	x.Propbe5f154d0e05458c9d7ce453640277f7 = new List<Class392a7b6ce9f64a41a208778aa5c3e347>(RndData.GetList(10, Class392a7b6ce9f64a41a208778aa5c3e347.CreateWithRandomData));
return x;
}
}

public class Class8cc3c55900ec4b6cb7e3d21dcb2f7aae : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propa4e2d854a0b74962be02d9703ec5d94f {get; set;}

	public virtual string Prop6081993b833c487aae46915fa8f0f4e3 {get; set;}

	public virtual bool Prop93d4be53593f4b499f915377102a167e {get; set;}

	public virtual int Prop35709af0cf444e9385ec6ece267a52de {get; set;}

	public virtual bool Prop0ebb6fc2839248b6b1f38230c55689df {get; set;}

	public virtual bool Prop09b9e373aa4146fcbe15c96a3193c389 {get; set;}

	public virtual bool Propfd8de2fbca554fefa4a2adb586d5c326 {get; set;}

	public virtual string Prop916e399ba79c43e893425e85bd6e99b1 {get; set;}

	public virtual bool Prop9d31afef6deb4aca92558b172d2cc180 {get; set;}

	public virtual string Prop99c7811775fd46a685047c1553434c46 {get; set;}

	public virtual int Prop4804b0747c77452d8676893afbba989a {get; set;}

	public virtual string Prop286033e3096943f580048a22af8faa81 {get; set;}

	public virtual string Prop553379e0e80940a989adc78976c184b6 {get; set;}

	public virtual string Propa94c77db40a74e95ad75fc0b355bb9db {get; set;}

	public virtual int Prop687d187a92cb4f5fb75b278351b04bd4 {get; set;}

	public virtual string Prop5e0d3048627b4550a950d1a96daddc7a {get; set;}

	public virtual bool Propa4099a87794b4ac79d5e3c4efb217ef4 {get; set;}

	public virtual string Prop22a540d36a124699b2b67dca7824da3c {get; set;}

	public virtual string Propf73c6da869e74cfd8c862d77b1b29aba {get; set;}

	public virtual int Prop9c81fd751fb144828c1a854b78c934b9 {get; set;}

	public virtual string Prop1a327e09b42142f98335714824222e71 {get; set;}

public static Class8cc3c55900ec4b6cb7e3d21dcb2f7aae CreateWithRandomData()
{
	var x = new Class8cc3c55900ec4b6cb7e3d21dcb2f7aae();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propa4e2d854a0b74962be02d9703ec5d94f = RndData.GetInt();
	x.Prop6081993b833c487aae46915fa8f0f4e3 = RndData.GetString();
	x.Prop93d4be53593f4b499f915377102a167e = RndData.GetBool();
	x.Prop35709af0cf444e9385ec6ece267a52de = RndData.GetInt();
	x.Prop0ebb6fc2839248b6b1f38230c55689df = RndData.GetBool();
	x.Prop09b9e373aa4146fcbe15c96a3193c389 = RndData.GetBool();
	x.Propfd8de2fbca554fefa4a2adb586d5c326 = RndData.GetBool();
	x.Prop916e399ba79c43e893425e85bd6e99b1 = RndData.GetString();
	x.Prop9d31afef6deb4aca92558b172d2cc180 = RndData.GetBool();
	x.Prop99c7811775fd46a685047c1553434c46 = RndData.GetString();
	x.Prop4804b0747c77452d8676893afbba989a = RndData.GetInt();
	x.Prop286033e3096943f580048a22af8faa81 = RndData.GetString();
	x.Prop553379e0e80940a989adc78976c184b6 = RndData.GetString();
	x.Propa94c77db40a74e95ad75fc0b355bb9db = RndData.GetString();
	x.Prop687d187a92cb4f5fb75b278351b04bd4 = RndData.GetInt();
	x.Prop5e0d3048627b4550a950d1a96daddc7a = RndData.GetString();
	x.Propa4099a87794b4ac79d5e3c4efb217ef4 = RndData.GetBool();
	x.Prop22a540d36a124699b2b67dca7824da3c = RndData.GetString();
	x.Propf73c6da869e74cfd8c862d77b1b29aba = RndData.GetString();
	x.Prop9c81fd751fb144828c1a854b78c934b9 = RndData.GetInt();
	x.Prop1a327e09b42142f98335714824222e71 = RndData.GetString();
return x;
}
}

public class Class9e78866c3b954c26a00deef1c7900550 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop7739a04d45de4aee94300682985cc9c7 {get; set;}

	public virtual string Prop18096e1913234a27972bc34258e3a62d {get; set;}

	public virtual bool Prop8bf2835a6c544d579f0f1e29da46fa24 {get; set;}

	public virtual bool Prop5579c5865548487988e81bd776ed9dd9 {get; set;}

	public virtual int Prop62982490859b450fabbd75461e87f8be {get; set;}

	public virtual int Prop1141975b9d99408fb9c65f91e6672d2a {get; set;}

	public virtual bool Prop84409106fee54ca9b89338418bafa444 {get; set;}

	public virtual bool Propbc1e8fafeb2f4e58ad67d25bef6436b6 {get; set;}

	public virtual bool Prop503e885b6991463195ca7cbe6da2fc74 {get; set;}

	public virtual string Prop82fe023907804ff4942cc36d8c6217a1 {get; set;}

	public virtual string Prop2adeb8826aa54cd3a4f128eb0c2ea3e6 {get; set;}

	public virtual int Prop2fb43a13f2f14506ae0e8ae2f0c0ba53 {get; set;}

	public virtual bool Propdf30ed29bb2c4bd1add25136b05753b8 {get; set;}

	public virtual string Prop2d40f9356a1043a595eea6fd54dc26e4 {get; set;}

	public virtual string Prop90744ec3709a4db4bfdeeef54ffe6d5e {get; set;}

	public virtual bool Prop60703136996f4ea1bbbec6ad5b0b8395 {get; set;}

	public virtual string Propae3b94af76b245bcbfd35a8e88e15875 {get; set;}

	public virtual string Prope3181321eae24eb592a864ff806f8def {get; set;}

	public virtual bool Prop57f8ab37678e4b48a8d6a79b7e095571 {get; set;}

	public virtual bool Prope414635adcc647d2ada11508c5577df0 {get; set;}

	public virtual bool Propc0fe3b6f115e4c01985d1656ddd94092 {get; set;}

	public virtual int Prop86d67033305b44769e19360547ba089a {get; set;}

	public virtual string Propa2136213e0784775b86029516336ef06 {get; set;}

	public virtual string Prop8376775ce3bf4b3b866ecf54af3ad6bc {get; set;}

	public virtual int Propa619ced246f74452894579d007c7cbd6 {get; set;}

	public virtual bool Prop505718de40414fbabbce92a3dcfc95db {get; set;}

	public virtual string Prop02b68c27f9f44f0da947161b88e6ea77 {get; set;}

	public virtual bool Prop32c391f49f7742c697229f97edba8052 {get; set;}

	public virtual string Prop0f9538f6d00142b2bb2f8eb588ffe9fb {get; set;}

	public virtual int Prop4d1f9c9437f64b11b583a1a674ca3df1 {get; set;}

public static Class9e78866c3b954c26a00deef1c7900550 CreateWithRandomData()
{
	var x = new Class9e78866c3b954c26a00deef1c7900550();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop7739a04d45de4aee94300682985cc9c7 = RndData.GetBool();
	x.Prop18096e1913234a27972bc34258e3a62d = RndData.GetString();
	x.Prop8bf2835a6c544d579f0f1e29da46fa24 = RndData.GetBool();
	x.Prop5579c5865548487988e81bd776ed9dd9 = RndData.GetBool();
	x.Prop62982490859b450fabbd75461e87f8be = RndData.GetInt();
	x.Prop1141975b9d99408fb9c65f91e6672d2a = RndData.GetInt();
	x.Prop84409106fee54ca9b89338418bafa444 = RndData.GetBool();
	x.Propbc1e8fafeb2f4e58ad67d25bef6436b6 = RndData.GetBool();
	x.Prop503e885b6991463195ca7cbe6da2fc74 = RndData.GetBool();
	x.Prop82fe023907804ff4942cc36d8c6217a1 = RndData.GetString();
	x.Prop2adeb8826aa54cd3a4f128eb0c2ea3e6 = RndData.GetString();
	x.Prop2fb43a13f2f14506ae0e8ae2f0c0ba53 = RndData.GetInt();
	x.Propdf30ed29bb2c4bd1add25136b05753b8 = RndData.GetBool();
	x.Prop2d40f9356a1043a595eea6fd54dc26e4 = RndData.GetString();
	x.Prop90744ec3709a4db4bfdeeef54ffe6d5e = RndData.GetString();
	x.Prop60703136996f4ea1bbbec6ad5b0b8395 = RndData.GetBool();
	x.Propae3b94af76b245bcbfd35a8e88e15875 = RndData.GetString();
	x.Prope3181321eae24eb592a864ff806f8def = RndData.GetString();
	x.Prop57f8ab37678e4b48a8d6a79b7e095571 = RndData.GetBool();
	x.Prope414635adcc647d2ada11508c5577df0 = RndData.GetBool();
	x.Propc0fe3b6f115e4c01985d1656ddd94092 = RndData.GetBool();
	x.Prop86d67033305b44769e19360547ba089a = RndData.GetInt();
	x.Propa2136213e0784775b86029516336ef06 = RndData.GetString();
	x.Prop8376775ce3bf4b3b866ecf54af3ad6bc = RndData.GetString();
	x.Propa619ced246f74452894579d007c7cbd6 = RndData.GetInt();
	x.Prop505718de40414fbabbce92a3dcfc95db = RndData.GetBool();
	x.Prop02b68c27f9f44f0da947161b88e6ea77 = RndData.GetString();
	x.Prop32c391f49f7742c697229f97edba8052 = RndData.GetBool();
	x.Prop0f9538f6d00142b2bb2f8eb588ffe9fb = RndData.GetString();
	x.Prop4d1f9c9437f64b11b583a1a674ca3df1 = RndData.GetInt();
return x;
}
}

public class Class392a7b6ce9f64a41a208778aa5c3e347 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop3699d25ded034c81877befe7e1064a20 {get; set;}

	public virtual string Propc99804c1059e48a18db554357ee34d96 {get; set;}

	public virtual string Prop0f53ed94614a489a9795126f23cf8abe {get; set;}

	public virtual int Prop371777865a194bac8f5cbd51ba6f8b4f {get; set;}

	public virtual bool Propfd81ceaff33244d495f0d05f3881cc20 {get; set;}

	public virtual string Propa8a90453e6fb43f68378dfa183eb69f3 {get; set;}

	public virtual bool Prop70ce8218395948d1b2fff1074bab621e {get; set;}

	public virtual int Prop4fbf596f664847c6828af2139b0e720f {get; set;}

	public virtual int Prop36141b2c2f0249dfb3df1966524b6cb5 {get; set;}

	public virtual int Propf819fe65741f45529950592b4af5bc5a {get; set;}

	public virtual int Prop44b47c50a7904c3a9c144686cae390da {get; set;}

	public virtual bool Prop3b78b505e53b441c96bc932217c64470 {get; set;}

	public virtual bool Propd60b6cdfb9f84100b5d61c0cc294dda0 {get; set;}

	public virtual string Prop6feab8884d0e4fc19199fbf3004f7fb2 {get; set;}

	public virtual bool Propb73575aeae304e518ddaa70cc487567e {get; set;}

	public virtual int Propcaf5943f229e486ca5f672d5f68c770c {get; set;}

	public virtual string Propbd62a1eb07874bdd83cf0d7cecf28d47 {get; set;}

	public virtual string Propc64ccda531f7407bacdc113ab8506bd3 {get; set;}

	public virtual bool Prop4374444c5cdb4db8ad88eec21a13414e {get; set;}

	public virtual int Propbeddaf8deec241b19b140aeb4f531fac {get; set;}

	public virtual string Prop46ad33d821cd46d69f6895c363fa13f7 {get; set;}

	public virtual int Prop8fb8ebdfd81f4f01a55922ece5c52e6e {get; set;}

	public virtual bool Prop2bc7b410a3d34ee69ecde1e8afcb7ef4 {get; set;}

	public virtual int Prop95e856058fd242a693048b8c74b0cee6 {get; set;}

	public virtual string Prop5581172bd832419ba6a6b835084b95c4 {get; set;}

	public virtual int Prop766251084e444ca3bfc8e1e9e4b39e87 {get; set;}

	public virtual bool Prop737a065b0d3b4c02a945f9c3aa30dac4 {get; set;}

	public virtual bool Prop5cdf777ef014478bad026acce02e77ed {get; set;}

	public virtual bool Prop28fe0a711d2a4d0487a0b2f5185a9eb1 {get; set;}

	public virtual int Prop35f802acb06d473db9d209091036408e {get; set;}

public static Class392a7b6ce9f64a41a208778aa5c3e347 CreateWithRandomData()
{
	var x = new Class392a7b6ce9f64a41a208778aa5c3e347();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop3699d25ded034c81877befe7e1064a20 = RndData.GetString();
	x.Propc99804c1059e48a18db554357ee34d96 = RndData.GetString();
	x.Prop0f53ed94614a489a9795126f23cf8abe = RndData.GetString();
	x.Prop371777865a194bac8f5cbd51ba6f8b4f = RndData.GetInt();
	x.Propfd81ceaff33244d495f0d05f3881cc20 = RndData.GetBool();
	x.Propa8a90453e6fb43f68378dfa183eb69f3 = RndData.GetString();
	x.Prop70ce8218395948d1b2fff1074bab621e = RndData.GetBool();
	x.Prop4fbf596f664847c6828af2139b0e720f = RndData.GetInt();
	x.Prop36141b2c2f0249dfb3df1966524b6cb5 = RndData.GetInt();
	x.Propf819fe65741f45529950592b4af5bc5a = RndData.GetInt();
	x.Prop44b47c50a7904c3a9c144686cae390da = RndData.GetInt();
	x.Prop3b78b505e53b441c96bc932217c64470 = RndData.GetBool();
	x.Propd60b6cdfb9f84100b5d61c0cc294dda0 = RndData.GetBool();
	x.Prop6feab8884d0e4fc19199fbf3004f7fb2 = RndData.GetString();
	x.Propb73575aeae304e518ddaa70cc487567e = RndData.GetBool();
	x.Propcaf5943f229e486ca5f672d5f68c770c = RndData.GetInt();
	x.Propbd62a1eb07874bdd83cf0d7cecf28d47 = RndData.GetString();
	x.Propc64ccda531f7407bacdc113ab8506bd3 = RndData.GetString();
	x.Prop4374444c5cdb4db8ad88eec21a13414e = RndData.GetBool();
	x.Propbeddaf8deec241b19b140aeb4f531fac = RndData.GetInt();
	x.Prop46ad33d821cd46d69f6895c363fa13f7 = RndData.GetString();
	x.Prop8fb8ebdfd81f4f01a55922ece5c52e6e = RndData.GetInt();
	x.Prop2bc7b410a3d34ee69ecde1e8afcb7ef4 = RndData.GetBool();
	x.Prop95e856058fd242a693048b8c74b0cee6 = RndData.GetInt();
	x.Prop5581172bd832419ba6a6b835084b95c4 = RndData.GetString();
	x.Prop766251084e444ca3bfc8e1e9e4b39e87 = RndData.GetInt();
	x.Prop737a065b0d3b4c02a945f9c3aa30dac4 = RndData.GetBool();
	x.Prop5cdf777ef014478bad026acce02e77ed = RndData.GetBool();
	x.Prop28fe0a711d2a4d0487a0b2f5185a9eb1 = RndData.GetBool();
	x.Prop35f802acb06d473db9d209091036408e = RndData.GetInt();
return x;
}
}

public class Classf9e243f8d1494e69be6b959fc813c2a2 : IEntity
{
	public virtual string Id {get; set;}

	public virtual Class9a98271ce8f049d78b085a864a023cfe Propfa0c5abfb0f34442bf0a946e487f7791 {get; set;}

	public virtual bool Propf5955279a2e144e68be15275a21afe0c {get; set;}

	public virtual int Prop6e07632bb606437a8609bd088a329329 {get; set;}

	public virtual bool Propf5212dac56124157977662ada77b2cca {get; set;}

	public virtual bool Propdfb77829118a4bf298bbeac39dcb7a1f {get; set;}

	public virtual bool Propb42c5acc4bd74557a099b6e62093376a {get; set;}

	public virtual string Prop449262447c79406d9f6928db4f5f1219 {get; set;}

	public virtual int Prop141c431b972d4da5a977c911b37008da {get; set;}

	public virtual string Prop7b4626b099ac441484e0e54e17c5ab32 {get; set;}

	public virtual string Prop31b114af356a471a8bcfd935835f1ce3 {get; set;}

	public virtual string Propdd6dcad46f774b1dad53fc97e254342b {get; set;}

	public virtual int Propac77fbbe7bba467db252c52192746eef {get; set;}

	public virtual int Prop9eaa351e0927449cb88371f5b70982c9 {get; set;}

	public virtual bool Prop15f1e34ee810486dbefe4a246b3ca5ae {get; set;}

	public virtual bool Prop0c4ac4cba1d84207ba490ef302696142 {get; set;}

	public virtual string Propb021d22510724dbf8084ea3adf78e971 {get; set;}

	public virtual int Prop868a198dce654eddae9322bfb3fa5ab9 {get; set;}

	public virtual int Propa6991b0fd0424e68a21176ea07572089 {get; set;}

	public virtual string Propa83076a23fca4158ac3628552a348852 {get; set;}

	public virtual Classc82f6fb212b84f7c8c34ce11abbbda6b Prop37f1c7b380344162937b3769b754309c {get; set;}

	public virtual int Prop7298646dafd64e39a32518cdda03fb1f {get; set;}

	public virtual string Propc7488513f8334caf909f25c86114c2d2 {get; set;}

	public virtual string Propf5332547181d4ed8b4c799e8b88eca9d {get; set;}

	public virtual string Propbd9a39cc149f4f61809d07ed0ce19d9c {get; set;}

public static Classf9e243f8d1494e69be6b959fc813c2a2 CreateWithRandomData()
{
	var x = new Classf9e243f8d1494e69be6b959fc813c2a2();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propfa0c5abfb0f34442bf0a946e487f7791 = Class9a98271ce8f049d78b085a864a023cfe.CreateWithRandomData();
	x.Propf5955279a2e144e68be15275a21afe0c = RndData.GetBool();
	x.Prop6e07632bb606437a8609bd088a329329 = RndData.GetInt();
	x.Propf5212dac56124157977662ada77b2cca = RndData.GetBool();
	x.Propdfb77829118a4bf298bbeac39dcb7a1f = RndData.GetBool();
	x.Propb42c5acc4bd74557a099b6e62093376a = RndData.GetBool();
	x.Prop449262447c79406d9f6928db4f5f1219 = RndData.GetString();
	x.Prop141c431b972d4da5a977c911b37008da = RndData.GetInt();
	x.Prop7b4626b099ac441484e0e54e17c5ab32 = RndData.GetString();
	x.Prop31b114af356a471a8bcfd935835f1ce3 = RndData.GetString();
	x.Propdd6dcad46f774b1dad53fc97e254342b = RndData.GetString();
	x.Propac77fbbe7bba467db252c52192746eef = RndData.GetInt();
	x.Prop9eaa351e0927449cb88371f5b70982c9 = RndData.GetInt();
	x.Prop15f1e34ee810486dbefe4a246b3ca5ae = RndData.GetBool();
	x.Prop0c4ac4cba1d84207ba490ef302696142 = RndData.GetBool();
	x.Propb021d22510724dbf8084ea3adf78e971 = RndData.GetString();
	x.Prop868a198dce654eddae9322bfb3fa5ab9 = RndData.GetInt();
	x.Propa6991b0fd0424e68a21176ea07572089 = RndData.GetInt();
	x.Propa83076a23fca4158ac3628552a348852 = RndData.GetString();
	x.Prop37f1c7b380344162937b3769b754309c = Classc82f6fb212b84f7c8c34ce11abbbda6b.CreateWithRandomData();
	x.Prop7298646dafd64e39a32518cdda03fb1f = RndData.GetInt();
	x.Propc7488513f8334caf909f25c86114c2d2 = RndData.GetString();
	x.Propf5332547181d4ed8b4c799e8b88eca9d = RndData.GetString();
	x.Propbd9a39cc149f4f61809d07ed0ce19d9c = RndData.GetString();
return x;
}
}

public class Class9a98271ce8f049d78b085a864a023cfe : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop78a2420636a04b3eaab49ff65e772865 {get; set;}

	public virtual bool Prop927cbda59969495c84f05d027c0cc1a7 {get; set;}

	public virtual string Prop613e062c882e42f7a0b03809f54b0847 {get; set;}

	public virtual string Prop44d77e698bba43d29b992a6efe2fba68 {get; set;}

	public virtual int Propf1569e83abdc4a5ebd8c4b07429ba2f2 {get; set;}

	public virtual int Prop341ce49fe3b04515a29aeb977069df63 {get; set;}

	public virtual string Prop68686df4bb134ccba26e4638f808992c {get; set;}

	public virtual int Propaaef0a3b686d4c82b2db325b1e69c7ab {get; set;}

	public virtual int Propb6fd09e85a9d40f5a44b1fa5593014cb {get; set;}

	public virtual bool Prop0d1d676c645a4442bf318d3828bd669d {get; set;}

	public virtual int Prop3994cd1f97d14f529097bec6c9326ec5 {get; set;}

	public virtual int Prop178341b7013446a7954c303a8f97ba08 {get; set;}

	public virtual bool Prop88d64e70ac794f23b64d5ade88b52000 {get; set;}

	public virtual bool Prop8ede39371830454dbd463b235b0374f9 {get; set;}

	public virtual string Prop337042c781a04afc876c328a2e3f3c0a {get; set;}

	public virtual bool Propfb29b7ea8eb9457894db7f5b4eebd8bc {get; set;}

	public virtual bool Propc994ebcb20a04ab08fd1aa74d1cf6937 {get; set;}

	public virtual bool Propa27025168a0e4ca785a2952cad017b2f {get; set;}

	public virtual int Prop5bc19996991c4d0eaf832767377188ff {get; set;}

	public virtual int Propbedcc6e14b434a70b11bcce3c7b07ee4 {get; set;}

	public virtual string Prop1684ecc0a7b24066a710d82e15cb3a6b {get; set;}

	public virtual string Prop2d297fab8ca746c592480e769caa9539 {get; set;}

	public virtual int Prop0929431b98c844028c5e3b32a8452d1b {get; set;}

	public virtual int Propd00c4a303bc34f14b4fb9bc6c45f5705 {get; set;}

	public virtual bool Propae0ef441435b446381b8d00b93ace371 {get; set;}

public static Class9a98271ce8f049d78b085a864a023cfe CreateWithRandomData()
{
	var x = new Class9a98271ce8f049d78b085a864a023cfe();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop78a2420636a04b3eaab49ff65e772865 = RndData.GetString();
	x.Prop927cbda59969495c84f05d027c0cc1a7 = RndData.GetBool();
	x.Prop613e062c882e42f7a0b03809f54b0847 = RndData.GetString();
	x.Prop44d77e698bba43d29b992a6efe2fba68 = RndData.GetString();
	x.Propf1569e83abdc4a5ebd8c4b07429ba2f2 = RndData.GetInt();
	x.Prop341ce49fe3b04515a29aeb977069df63 = RndData.GetInt();
	x.Prop68686df4bb134ccba26e4638f808992c = RndData.GetString();
	x.Propaaef0a3b686d4c82b2db325b1e69c7ab = RndData.GetInt();
	x.Propb6fd09e85a9d40f5a44b1fa5593014cb = RndData.GetInt();
	x.Prop0d1d676c645a4442bf318d3828bd669d = RndData.GetBool();
	x.Prop3994cd1f97d14f529097bec6c9326ec5 = RndData.GetInt();
	x.Prop178341b7013446a7954c303a8f97ba08 = RndData.GetInt();
	x.Prop88d64e70ac794f23b64d5ade88b52000 = RndData.GetBool();
	x.Prop8ede39371830454dbd463b235b0374f9 = RndData.GetBool();
	x.Prop337042c781a04afc876c328a2e3f3c0a = RndData.GetString();
	x.Propfb29b7ea8eb9457894db7f5b4eebd8bc = RndData.GetBool();
	x.Propc994ebcb20a04ab08fd1aa74d1cf6937 = RndData.GetBool();
	x.Propa27025168a0e4ca785a2952cad017b2f = RndData.GetBool();
	x.Prop5bc19996991c4d0eaf832767377188ff = RndData.GetInt();
	x.Propbedcc6e14b434a70b11bcce3c7b07ee4 = RndData.GetInt();
	x.Prop1684ecc0a7b24066a710d82e15cb3a6b = RndData.GetString();
	x.Prop2d297fab8ca746c592480e769caa9539 = RndData.GetString();
	x.Prop0929431b98c844028c5e3b32a8452d1b = RndData.GetInt();
	x.Propd00c4a303bc34f14b4fb9bc6c45f5705 = RndData.GetInt();
	x.Propae0ef441435b446381b8d00b93ace371 = RndData.GetBool();
return x;
}
}

public class Classc82f6fb212b84f7c8c34ce11abbbda6b : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop68d6a20627a447cfbcba9d26ec375cc8 {get; set;}

	public virtual string Prop1285c0e18b2e49dc8e921b602dd0f899 {get; set;}

	public virtual string Prop80bea7cb424e4a5ebc5390ee44bee7ab {get; set;}

	public virtual string Prop0b33120f79274827808927169a1cbe67 {get; set;}

	public virtual string Prop9f0d46dfe6e14561b5c747cffee81641 {get; set;}

	public virtual string Propa193cf0c422d4eae98f715d9d068c835 {get; set;}

	public virtual string Prop0b0b69a9f9b04ba08181e3a9e8c23823 {get; set;}

	public virtual string Propd47a9c0937c44df9947a54aed339dbf9 {get; set;}

	public virtual string Prop43e34d47277149e59f3106ac95696cfd {get; set;}

	public virtual bool Propda607424b0ea434690d562e5af36f216 {get; set;}

	public virtual int Prop6eec35b5aa1946e5952907d6fb1fca50 {get; set;}

	public virtual int Propf7a7a529f37641ecaf87827f331d23ee {get; set;}

	public virtual int Prop3ee34e9ffc944437ad24551e419f66c2 {get; set;}

	public virtual int Prop8deb4108dfd94a929c494e2556188c1b {get; set;}

	public virtual int Prop6fd96503db454e138c4e208ad92cfae5 {get; set;}

	public virtual string Prop0c10e5691d8d41fdbfa8d80095cb9e21 {get; set;}

	public virtual string Prop6dc16b15c01f4ef984b4f6cc45232cb4 {get; set;}

	public virtual int Prop2bfa6032bdef402385c72b028734c29e {get; set;}

	public virtual string Propece3b8ffb7334e859c792aa06fee2c7b {get; set;}

	public virtual bool Prop7688ada027a14871bc57c5b0dd7fb132 {get; set;}

	public virtual bool Propf70c28d1dea743a48ef6901babe826ce {get; set;}

	public virtual bool Prop1536d3aacd0c4ac987c7914b1911850d {get; set;}

	public virtual string Prop00a05cfd83a046d3822eab326f420d23 {get; set;}

public static Classc82f6fb212b84f7c8c34ce11abbbda6b CreateWithRandomData()
{
	var x = new Classc82f6fb212b84f7c8c34ce11abbbda6b();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop68d6a20627a447cfbcba9d26ec375cc8 = RndData.GetString();
	x.Prop1285c0e18b2e49dc8e921b602dd0f899 = RndData.GetString();
	x.Prop80bea7cb424e4a5ebc5390ee44bee7ab = RndData.GetString();
	x.Prop0b33120f79274827808927169a1cbe67 = RndData.GetString();
	x.Prop9f0d46dfe6e14561b5c747cffee81641 = RndData.GetString();
	x.Propa193cf0c422d4eae98f715d9d068c835 = RndData.GetString();
	x.Prop0b0b69a9f9b04ba08181e3a9e8c23823 = RndData.GetString();
	x.Propd47a9c0937c44df9947a54aed339dbf9 = RndData.GetString();
	x.Prop43e34d47277149e59f3106ac95696cfd = RndData.GetString();
	x.Propda607424b0ea434690d562e5af36f216 = RndData.GetBool();
	x.Prop6eec35b5aa1946e5952907d6fb1fca50 = RndData.GetInt();
	x.Propf7a7a529f37641ecaf87827f331d23ee = RndData.GetInt();
	x.Prop3ee34e9ffc944437ad24551e419f66c2 = RndData.GetInt();
	x.Prop8deb4108dfd94a929c494e2556188c1b = RndData.GetInt();
	x.Prop6fd96503db454e138c4e208ad92cfae5 = RndData.GetInt();
	x.Prop0c10e5691d8d41fdbfa8d80095cb9e21 = RndData.GetString();
	x.Prop6dc16b15c01f4ef984b4f6cc45232cb4 = RndData.GetString();
	x.Prop2bfa6032bdef402385c72b028734c29e = RndData.GetInt();
	x.Propece3b8ffb7334e859c792aa06fee2c7b = RndData.GetString();
	x.Prop7688ada027a14871bc57c5b0dd7fb132 = RndData.GetBool();
	x.Propf70c28d1dea743a48ef6901babe826ce = RndData.GetBool();
	x.Prop1536d3aacd0c4ac987c7914b1911850d = RndData.GetBool();
	x.Prop00a05cfd83a046d3822eab326f420d23 = RndData.GetString();
return x;
}
}

public class Classab66337c42bc47f6873e2752f8c9e34f : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop9248c38417664491aca3f3d4b30d6ad1 {get; set;}

	public virtual string Prop1fe8ff04a89b4d68b9ab83a61cfc84be {get; set;}

	public virtual Class50bd5c30c17c4ef4af341f9e239e5be4 Prop3586a1f1dc7a4ce69d7296738d6934a8 {get; set;}

	public virtual Class52637e3af91348c584a6458d080e1c31 Propa4ce0dc2290b4bd1897174e5c2368afd {get; set;}

	public virtual bool Propdd2952abe5c44c0c9685846990f1d32c {get; set;}

	public virtual string Prop9ebd9259ebd44a71bf434e97fca44e8f {get; set;}

	public virtual string Propa2d985cd22d54beea57da05d02f3115f {get; set;}

	public virtual bool Prop4235347376304e94a1d59b24b6485790 {get; set;}

	public virtual bool Prop7725a1b887704f33bbaf8af91297e520 {get; set;}

	public virtual bool Prop7ba257fa9eea4f53bd62d80ca104f62b {get; set;}

	public virtual int Propb3642689857b48f781d8689019ef5145 {get; set;}

	public virtual string Propc799a99a20364f8599546ae509ca0154 {get; set;}

	public virtual int Prop6f9f5bddc7844be7a97e03ef6c8794a0 {get; set;}

public static Classab66337c42bc47f6873e2752f8c9e34f CreateWithRandomData()
{
	var x = new Classab66337c42bc47f6873e2752f8c9e34f();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop9248c38417664491aca3f3d4b30d6ad1 = RndData.GetBool();
	x.Prop1fe8ff04a89b4d68b9ab83a61cfc84be = RndData.GetString();
	x.Prop3586a1f1dc7a4ce69d7296738d6934a8 = Class50bd5c30c17c4ef4af341f9e239e5be4.CreateWithRandomData();
	x.Propa4ce0dc2290b4bd1897174e5c2368afd = Class52637e3af91348c584a6458d080e1c31.CreateWithRandomData();
	x.Propdd2952abe5c44c0c9685846990f1d32c = RndData.GetBool();
	x.Prop9ebd9259ebd44a71bf434e97fca44e8f = RndData.GetString();
	x.Propa2d985cd22d54beea57da05d02f3115f = RndData.GetString();
	x.Prop4235347376304e94a1d59b24b6485790 = RndData.GetBool();
	x.Prop7725a1b887704f33bbaf8af91297e520 = RndData.GetBool();
	x.Prop7ba257fa9eea4f53bd62d80ca104f62b = RndData.GetBool();
	x.Propb3642689857b48f781d8689019ef5145 = RndData.GetInt();
	x.Propc799a99a20364f8599546ae509ca0154 = RndData.GetString();
	x.Prop6f9f5bddc7844be7a97e03ef6c8794a0 = RndData.GetInt();
return x;
}
}

public class Class50bd5c30c17c4ef4af341f9e239e5be4 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Propc05bbe776f19478caf6be950aa68f0ec {get; set;}

	public virtual int Prop82a18894f805469ba21d7204a3297013 {get; set;}

	public virtual bool Prop1a6162fd0131454b8c5ffcec9bde9253 {get; set;}

	public virtual int Propf6927cef2450476faea364318e10ce26 {get; set;}

	public virtual string Prop98043c3a6a65439888f66d9a4cd43610 {get; set;}

	public virtual string Prop4b96e740db534b8bbed60602ab26e515 {get; set;}

	public virtual int Prop0be4f669bab24a29a237d18580ca78e7 {get; set;}

	public virtual bool Propf4635a12af7c401698bccd514f6eee91 {get; set;}

	public virtual bool Prop66798ef4aa3d470c97e9a1b1ccb901a3 {get; set;}

	public virtual bool Prop9294357341984a958a88c4ed60b47235 {get; set;}

	public virtual string Prop7c54401fb61c4beeb649382b80bc9d89 {get; set;}

	public virtual string Prop15f197b5e5894c84ae3e54dd108cde6c {get; set;}

	public virtual string Prop31dc3bfd86d546c9acff5de7e8605dbf {get; set;}

	public virtual int Prop31f3ddbe91f5454c8ececa8c45faccbf {get; set;}

	public virtual string Prop70bb93057651413da46d01bf8c02f471 {get; set;}

	public virtual string Prop826fa8bc70924cbfa33a8eb8dcb03477 {get; set;}

	public virtual int Propc62a7fee8c594cc19a0ff9ea23c33ff3 {get; set;}

	public virtual int Propa3595a182dbf4a82aebb044666abf226 {get; set;}

	public virtual int Prop92360b1e007a444f924be86801b74de3 {get; set;}

	public virtual bool Prop21ac42dea2f94299937be4eb402a69b6 {get; set;}

	public virtual bool Prop97d252027bb747c483686a763120303e {get; set;}

	public virtual int Propee078947cdad42908ff9301ca09e8ff1 {get; set;}

	public virtual string Prop5939b284365b40548ec6cd9bc19bef51 {get; set;}

	public virtual string Prop8534e02197ec4cd982b739428a6136c6 {get; set;}

	public virtual bool Prop6a25ac3c9de5424d950480bcbaad1ed8 {get; set;}

	public virtual bool Propf5d4975f4b174ec59646f527cb7a12f8 {get; set;}

	public virtual string Prope3bb7f8f9689459fb381c2e9f18b9f00 {get; set;}

public static Class50bd5c30c17c4ef4af341f9e239e5be4 CreateWithRandomData()
{
	var x = new Class50bd5c30c17c4ef4af341f9e239e5be4();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propc05bbe776f19478caf6be950aa68f0ec = RndData.GetString();
	x.Prop82a18894f805469ba21d7204a3297013 = RndData.GetInt();
	x.Prop1a6162fd0131454b8c5ffcec9bde9253 = RndData.GetBool();
	x.Propf6927cef2450476faea364318e10ce26 = RndData.GetInt();
	x.Prop98043c3a6a65439888f66d9a4cd43610 = RndData.GetString();
	x.Prop4b96e740db534b8bbed60602ab26e515 = RndData.GetString();
	x.Prop0be4f669bab24a29a237d18580ca78e7 = RndData.GetInt();
	x.Propf4635a12af7c401698bccd514f6eee91 = RndData.GetBool();
	x.Prop66798ef4aa3d470c97e9a1b1ccb901a3 = RndData.GetBool();
	x.Prop9294357341984a958a88c4ed60b47235 = RndData.GetBool();
	x.Prop7c54401fb61c4beeb649382b80bc9d89 = RndData.GetString();
	x.Prop15f197b5e5894c84ae3e54dd108cde6c = RndData.GetString();
	x.Prop31dc3bfd86d546c9acff5de7e8605dbf = RndData.GetString();
	x.Prop31f3ddbe91f5454c8ececa8c45faccbf = RndData.GetInt();
	x.Prop70bb93057651413da46d01bf8c02f471 = RndData.GetString();
	x.Prop826fa8bc70924cbfa33a8eb8dcb03477 = RndData.GetString();
	x.Propc62a7fee8c594cc19a0ff9ea23c33ff3 = RndData.GetInt();
	x.Propa3595a182dbf4a82aebb044666abf226 = RndData.GetInt();
	x.Prop92360b1e007a444f924be86801b74de3 = RndData.GetInt();
	x.Prop21ac42dea2f94299937be4eb402a69b6 = RndData.GetBool();
	x.Prop97d252027bb747c483686a763120303e = RndData.GetBool();
	x.Propee078947cdad42908ff9301ca09e8ff1 = RndData.GetInt();
	x.Prop5939b284365b40548ec6cd9bc19bef51 = RndData.GetString();
	x.Prop8534e02197ec4cd982b739428a6136c6 = RndData.GetString();
	x.Prop6a25ac3c9de5424d950480bcbaad1ed8 = RndData.GetBool();
	x.Propf5d4975f4b174ec59646f527cb7a12f8 = RndData.GetBool();
	x.Prope3bb7f8f9689459fb381c2e9f18b9f00 = RndData.GetString();
return x;
}
}

public class Class52637e3af91348c584a6458d080e1c31 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propcfff0419e5954ebb906375b2862a81e2 {get; set;}

	public virtual bool Propdeeaa7b5dc494d228bdda39cf6b85334 {get; set;}

	public virtual int Prop60f017b55b20404ab69225c3b252cf53 {get; set;}

	public virtual int Prop8dfbfcd7aeaa49698de8e6555aa72c9d {get; set;}

	public virtual bool Prop17a5b9416d2a48239c91f86c8d969b3b {get; set;}

	public virtual bool Propa6e108d2fd0a4ab7a6069fb686fdcfd0 {get; set;}

	public virtual int Prop606e0a8c8efa44ba8aeab779ec113aad {get; set;}

	public virtual bool Prop2019165d8d64492f897efc4557253c7c {get; set;}

	public virtual string Propb50bc9feac4f4cc68f92d439d9d235b8 {get; set;}

	public virtual int Propf323cd6a7b0d455fb074608f1bb94a2b {get; set;}

	public virtual int Propc54cbd4d8e554ecbbbc21812fe0e9af6 {get; set;}

	public virtual int Prop4a0d2c7f94274857b80103f1193f6ef4 {get; set;}

	public virtual string Prop93919d6a998949c8a4819c5e1c018bae {get; set;}

	public virtual bool Propfee321b66a7f4e0c87a980ded999ad3f {get; set;}

	public virtual int Propbc45333c9a1346e8aad0418eb37e5939 {get; set;}

public static Class52637e3af91348c584a6458d080e1c31 CreateWithRandomData()
{
	var x = new Class52637e3af91348c584a6458d080e1c31();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propcfff0419e5954ebb906375b2862a81e2 = RndData.GetInt();
	x.Propdeeaa7b5dc494d228bdda39cf6b85334 = RndData.GetBool();
	x.Prop60f017b55b20404ab69225c3b252cf53 = RndData.GetInt();
	x.Prop8dfbfcd7aeaa49698de8e6555aa72c9d = RndData.GetInt();
	x.Prop17a5b9416d2a48239c91f86c8d969b3b = RndData.GetBool();
	x.Propa6e108d2fd0a4ab7a6069fb686fdcfd0 = RndData.GetBool();
	x.Prop606e0a8c8efa44ba8aeab779ec113aad = RndData.GetInt();
	x.Prop2019165d8d64492f897efc4557253c7c = RndData.GetBool();
	x.Propb50bc9feac4f4cc68f92d439d9d235b8 = RndData.GetString();
	x.Propf323cd6a7b0d455fb074608f1bb94a2b = RndData.GetInt();
	x.Propc54cbd4d8e554ecbbbc21812fe0e9af6 = RndData.GetInt();
	x.Prop4a0d2c7f94274857b80103f1193f6ef4 = RndData.GetInt();
	x.Prop93919d6a998949c8a4819c5e1c018bae = RndData.GetString();
	x.Propfee321b66a7f4e0c87a980ded999ad3f = RndData.GetBool();
	x.Propbc45333c9a1346e8aad0418eb37e5939 = RndData.GetInt();
return x;
}
}

public class Class453f9ed8c4db40319708c5f741435b92 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop63b7d59386744094b1125be0bfacf7ae {get; set;}

	public virtual int Prop4c536ef422b543beae18f4a44fa92629 {get; set;}

	public virtual int Prop83b27966ae6043deb063fb417ac9f595 {get; set;}

	public virtual bool Prop8d8a4cfc8f0d4c0f97735ff8cadda219 {get; set;}

	public virtual bool Prop865861314322478186c9e26ddf988853 {get; set;}

	public virtual bool Propf6ec23f134c0435f9214746fd18b9878 {get; set;}

	public virtual string Propcf40176f2b614e4b9abda7ac188438a8 {get; set;}

	public virtual string Prop80c52de65861425092345199b47d6fc6 {get; set;}

	public virtual string Prop4ff0e03e5e4e4233aa4b1d22072f1046 {get; set;}

	public virtual bool Prop889c0bd0ba7643cb9de5966f062db88c {get; set;}

	public virtual bool Prop40ed03be0e1343e7aa29e7ce0773fab5 {get; set;}

	public virtual string Propa28e5e685b0547e68b92972d45d8df1e {get; set;}

	public virtual int Prop6e3e2191c9f94fa0b0773c0079021c32 {get; set;}

	public virtual ICollection<Class4860181a7bf34ecfaf74415c37b4c66a> Propf69f97e6e9874d10a391075b4f620807 {get; set;}

	public virtual bool Prop60408b760f0a46a8b500f541c76317a7 {get; set;}

	public virtual string Propdf0cf424eabc4e819b8ff5217769eeb1 {get; set;}

	public virtual bool Prop54c5957f6b07437c8facce2423b65d61 {get; set;}

	public virtual int Prop02d87085f3714df48d97939c860def83 {get; set;}

	public virtual bool Propbcdb5988f48a4555953928044a3736c3 {get; set;}

	public virtual int Propfa815075c6184ed793088d4c4a806612 {get; set;}

	public virtual string Prop8fb912ee103a420187d35743c12362ed {get; set;}

public static Class453f9ed8c4db40319708c5f741435b92 CreateWithRandomData()
{
	var x = new Class453f9ed8c4db40319708c5f741435b92();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop63b7d59386744094b1125be0bfacf7ae = RndData.GetBool();
	x.Prop4c536ef422b543beae18f4a44fa92629 = RndData.GetInt();
	x.Prop83b27966ae6043deb063fb417ac9f595 = RndData.GetInt();
	x.Prop8d8a4cfc8f0d4c0f97735ff8cadda219 = RndData.GetBool();
	x.Prop865861314322478186c9e26ddf988853 = RndData.GetBool();
	x.Propf6ec23f134c0435f9214746fd18b9878 = RndData.GetBool();
	x.Propcf40176f2b614e4b9abda7ac188438a8 = RndData.GetString();
	x.Prop80c52de65861425092345199b47d6fc6 = RndData.GetString();
	x.Prop4ff0e03e5e4e4233aa4b1d22072f1046 = RndData.GetString();
	x.Prop889c0bd0ba7643cb9de5966f062db88c = RndData.GetBool();
	x.Prop40ed03be0e1343e7aa29e7ce0773fab5 = RndData.GetBool();
	x.Propa28e5e685b0547e68b92972d45d8df1e = RndData.GetString();
	x.Prop6e3e2191c9f94fa0b0773c0079021c32 = RndData.GetInt();
	x.Propf69f97e6e9874d10a391075b4f620807 = new List<Class4860181a7bf34ecfaf74415c37b4c66a>(RndData.GetList(10, Class4860181a7bf34ecfaf74415c37b4c66a.CreateWithRandomData));
	x.Prop60408b760f0a46a8b500f541c76317a7 = RndData.GetBool();
	x.Propdf0cf424eabc4e819b8ff5217769eeb1 = RndData.GetString();
	x.Prop54c5957f6b07437c8facce2423b65d61 = RndData.GetBool();
	x.Prop02d87085f3714df48d97939c860def83 = RndData.GetInt();
	x.Propbcdb5988f48a4555953928044a3736c3 = RndData.GetBool();
	x.Propfa815075c6184ed793088d4c4a806612 = RndData.GetInt();
	x.Prop8fb912ee103a420187d35743c12362ed = RndData.GetString();
return x;
}
}

public class Class4860181a7bf34ecfaf74415c37b4c66a : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop3de794e5bc6b41838f2ee3a530bbeeee {get; set;}

	public virtual int Propce405c529ec14c8e869df16aa6e582d3 {get; set;}

	public virtual int Propc8c24f3ce6414173ac3e5a14f9d4b86d {get; set;}

	public virtual string Prop416ab809bf1748af92eb3d96f646d8e4 {get; set;}

	public virtual string Prop676408c60f6240fc99161331fdf37d18 {get; set;}

	public virtual int Propd739559a69bc47259c6ff930e8a27a06 {get; set;}

	public virtual bool Prop4ebaa5879bec41aa9ca9bd39b6b620ad {get; set;}

	public virtual bool Propc9e5f05065a74a778d235cf05ccf7cff {get; set;}

	public virtual bool Prop9bca91f2e97841c59df99a4a2acd2bd5 {get; set;}

	public virtual int Prop52b27298391b4a808f7ee8278b0e35cc {get; set;}

	public virtual string Prop85307b20e25c40f2af587f93c20bec1f {get; set;}

	public virtual bool Propb7ab0bcf437a46cfb26b563782680923 {get; set;}

	public virtual string Propef58c7f8991340ee9b259bee21948bb0 {get; set;}

	public virtual bool Propcb2235d6b4c94f518b6b540cbdf6ba76 {get; set;}

	public virtual bool Prop4dc37a8598f84a3a96bb26b75b4b4228 {get; set;}

	public virtual string Propac0bd37af699413288179059600262c9 {get; set;}

public static Class4860181a7bf34ecfaf74415c37b4c66a CreateWithRandomData()
{
	var x = new Class4860181a7bf34ecfaf74415c37b4c66a();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop3de794e5bc6b41838f2ee3a530bbeeee = RndData.GetString();
	x.Propce405c529ec14c8e869df16aa6e582d3 = RndData.GetInt();
	x.Propc8c24f3ce6414173ac3e5a14f9d4b86d = RndData.GetInt();
	x.Prop416ab809bf1748af92eb3d96f646d8e4 = RndData.GetString();
	x.Prop676408c60f6240fc99161331fdf37d18 = RndData.GetString();
	x.Propd739559a69bc47259c6ff930e8a27a06 = RndData.GetInt();
	x.Prop4ebaa5879bec41aa9ca9bd39b6b620ad = RndData.GetBool();
	x.Propc9e5f05065a74a778d235cf05ccf7cff = RndData.GetBool();
	x.Prop9bca91f2e97841c59df99a4a2acd2bd5 = RndData.GetBool();
	x.Prop52b27298391b4a808f7ee8278b0e35cc = RndData.GetInt();
	x.Prop85307b20e25c40f2af587f93c20bec1f = RndData.GetString();
	x.Propb7ab0bcf437a46cfb26b563782680923 = RndData.GetBool();
	x.Propef58c7f8991340ee9b259bee21948bb0 = RndData.GetString();
	x.Propcb2235d6b4c94f518b6b540cbdf6ba76 = RndData.GetBool();
	x.Prop4dc37a8598f84a3a96bb26b75b4b4228 = RndData.GetBool();
	x.Propac0bd37af699413288179059600262c9 = RndData.GetString();
return x;
}
}

public class Classc0096349cfd94b58b2b2e08acabe6fd6 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Propde6b7fccb84348468d1647c04f181e5f {get; set;}

	public virtual bool Prop421cc78cb0aa43e284376a37f2a5c69b {get; set;}

	public virtual bool Propd5ae4b5db069439c99397dc959c01f61 {get; set;}

	public virtual string Prop5f9185b623d64bcbb468efa8986b356e {get; set;}

	public virtual int Propf14e14f20ecb4e9097b8a2dfa81b6459 {get; set;}

	public virtual int Prop9582805d2c80478b8bf20529c27622e0 {get; set;}

	public virtual string Prop98b11b38072447a98b3b558bc43c981b {get; set;}

	public virtual bool Prop65048a3b98e0426cad6853a6de70432f {get; set;}

	public virtual bool Prop32170ac2256b43e097bc59dfcad2a54c {get; set;}

	public virtual string Propf54e67d84ee04c5582348f5947380be2 {get; set;}

	public virtual string Prop973fbd97241545e5af3384de36ae38eb {get; set;}

	public virtual string Prop9a95cccc60a04664b70eac471be930e8 {get; set;}

	public virtual int Propd19fb3c713b043588304dd903bf896b3 {get; set;}

	public virtual int Propc782969c936d42a1b2080c499fff5a18 {get; set;}

	public virtual string Propefca45cbc460477db01b8bb805ea8abf {get; set;}

	public virtual bool Prop92f94618d05148e6a8069df0d7291c2f {get; set;}

	public virtual int Prop722f7010ae324ef1925256b82637ab15 {get; set;}

	public virtual string Propb98c3008e78a484181f2d96019130485 {get; set;}

	public virtual Classa2d9a78e453a49059e1ece2b01e89b4c Prop1f59971f940e4e4aa9e3930055fd61dd {get; set;}

	public virtual bool Propc4657ea308794afd9289a19495199798 {get; set;}

	public virtual bool Propf10b90c8aff74951a09c5892e534318e {get; set;}

	public virtual bool Prop69d58f60800749cf902673cc21049698 {get; set;}

	public virtual bool Prop0af119053cb144acb2ad868804a178f4 {get; set;}

public static Classc0096349cfd94b58b2b2e08acabe6fd6 CreateWithRandomData()
{
	var x = new Classc0096349cfd94b58b2b2e08acabe6fd6();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propde6b7fccb84348468d1647c04f181e5f = RndData.GetString();
	x.Prop421cc78cb0aa43e284376a37f2a5c69b = RndData.GetBool();
	x.Propd5ae4b5db069439c99397dc959c01f61 = RndData.GetBool();
	x.Prop5f9185b623d64bcbb468efa8986b356e = RndData.GetString();
	x.Propf14e14f20ecb4e9097b8a2dfa81b6459 = RndData.GetInt();
	x.Prop9582805d2c80478b8bf20529c27622e0 = RndData.GetInt();
	x.Prop98b11b38072447a98b3b558bc43c981b = RndData.GetString();
	x.Prop65048a3b98e0426cad6853a6de70432f = RndData.GetBool();
	x.Prop32170ac2256b43e097bc59dfcad2a54c = RndData.GetBool();
	x.Propf54e67d84ee04c5582348f5947380be2 = RndData.GetString();
	x.Prop973fbd97241545e5af3384de36ae38eb = RndData.GetString();
	x.Prop9a95cccc60a04664b70eac471be930e8 = RndData.GetString();
	x.Propd19fb3c713b043588304dd903bf896b3 = RndData.GetInt();
	x.Propc782969c936d42a1b2080c499fff5a18 = RndData.GetInt();
	x.Propefca45cbc460477db01b8bb805ea8abf = RndData.GetString();
	x.Prop92f94618d05148e6a8069df0d7291c2f = RndData.GetBool();
	x.Prop722f7010ae324ef1925256b82637ab15 = RndData.GetInt();
	x.Propb98c3008e78a484181f2d96019130485 = RndData.GetString();
	x.Prop1f59971f940e4e4aa9e3930055fd61dd = Classa2d9a78e453a49059e1ece2b01e89b4c.CreateWithRandomData();
	x.Propc4657ea308794afd9289a19495199798 = RndData.GetBool();
	x.Propf10b90c8aff74951a09c5892e534318e = RndData.GetBool();
	x.Prop69d58f60800749cf902673cc21049698 = RndData.GetBool();
	x.Prop0af119053cb144acb2ad868804a178f4 = RndData.GetBool();
return x;
}
}

public class Classa2d9a78e453a49059e1ece2b01e89b4c : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Propcb8e66f8b9854f3ebae7a010bf5bff86 {get; set;}

	public virtual int Prop84efd564ada445e3b00043fbe83f0c41 {get; set;}

	public virtual Class203fb173e4d0407c8a5093b52f9f3066 Prop3951674c040042a999a83fade2a72a47 {get; set;}

	public virtual string Propeaa0ab2af5d347668745de9e0abf1e34 {get; set;}

	public virtual string Prop3891c0723b8e44aeb7c8155cd84d6639 {get; set;}

	public virtual int Prop629c319c7a6b4cd69a61bd5dfd1c4fc9 {get; set;}

	public virtual string Propfab145a2265947a3b844ac8b22e1a810 {get; set;}

	public virtual string Propf47d7dd8113b4ca78716cf513a42a154 {get; set;}

	public virtual ICollection<Classa1562329032c47bfbccac58a21fa782f> Prop8785b32ddae04a41b2d975ede3d568dd {get; set;}

	public virtual bool Prop06b1f48603474821850b2249635382db {get; set;}

	public virtual bool Propccd843f012e04b32ba72cdefafd7eba5 {get; set;}

	public virtual bool Prop87706d1121f2442ba668306ec2a4d380 {get; set;}

	public virtual string Propa12f18dde42f4f928b005b887590a42f {get; set;}

	public virtual bool Prop3cd582e9c4414d06b47731404cf6771e {get; set;}

	public virtual int Prop6b35d3ac6ba54db5942b7a438cd917d4 {get; set;}

	public virtual string Prop40680f372eff48e9bf998dbb2b88a811 {get; set;}

	public virtual bool Propf2a95ecff5a4407fad0299c65995c4ae {get; set;}

	public virtual int Prop1fa8680df0ba4218808feedae16b3d46 {get; set;}

public static Classa2d9a78e453a49059e1ece2b01e89b4c CreateWithRandomData()
{
	var x = new Classa2d9a78e453a49059e1ece2b01e89b4c();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propcb8e66f8b9854f3ebae7a010bf5bff86 = RndData.GetBool();
	x.Prop84efd564ada445e3b00043fbe83f0c41 = RndData.GetInt();
	x.Prop3951674c040042a999a83fade2a72a47 = Class203fb173e4d0407c8a5093b52f9f3066.CreateWithRandomData();
	x.Propeaa0ab2af5d347668745de9e0abf1e34 = RndData.GetString();
	x.Prop3891c0723b8e44aeb7c8155cd84d6639 = RndData.GetString();
	x.Prop629c319c7a6b4cd69a61bd5dfd1c4fc9 = RndData.GetInt();
	x.Propfab145a2265947a3b844ac8b22e1a810 = RndData.GetString();
	x.Propf47d7dd8113b4ca78716cf513a42a154 = RndData.GetString();
	x.Prop8785b32ddae04a41b2d975ede3d568dd = new List<Classa1562329032c47bfbccac58a21fa782f>(RndData.GetList(10, Classa1562329032c47bfbccac58a21fa782f.CreateWithRandomData));
	x.Prop06b1f48603474821850b2249635382db = RndData.GetBool();
	x.Propccd843f012e04b32ba72cdefafd7eba5 = RndData.GetBool();
	x.Prop87706d1121f2442ba668306ec2a4d380 = RndData.GetBool();
	x.Propa12f18dde42f4f928b005b887590a42f = RndData.GetString();
	x.Prop3cd582e9c4414d06b47731404cf6771e = RndData.GetBool();
	x.Prop6b35d3ac6ba54db5942b7a438cd917d4 = RndData.GetInt();
	x.Prop40680f372eff48e9bf998dbb2b88a811 = RndData.GetString();
	x.Propf2a95ecff5a4407fad0299c65995c4ae = RndData.GetBool();
	x.Prop1fa8680df0ba4218808feedae16b3d46 = RndData.GetInt();
return x;
}
}

public class Class203fb173e4d0407c8a5093b52f9f3066 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Propfd9859d6a3ce4e08a979ebb214de7cb3 {get; set;}

	public virtual string Propd4d5511352094b67aba529e768af98f1 {get; set;}

	public virtual string Prop67fad365d13c43a280a0242cfbd3e3c5 {get; set;}

	public virtual string Propdcdee590c6994d6095c36fbfeaf9fe29 {get; set;}

	public virtual int Prop9e37bf6097c348f8a0e19e1a2b168704 {get; set;}

	public virtual string Prop516883cbeb4a432facef5f11d01b68ae {get; set;}

	public virtual int Prop0e220fa2c0084612abe63257c84c6ac2 {get; set;}

	public virtual int Propcb8f797a371e4de2ad491fc8a4e05c0e {get; set;}

	public virtual bool Prop3c27e8d640a940d4a40e45d4a8e644e3 {get; set;}

	public virtual bool Prop23bcef6d729f4f1b94513df7967c000d {get; set;}

	public virtual bool Propbb15b4e0258a4912bd919d101e3ce0f8 {get; set;}

	public virtual int Prop5ccb6f2d4d5d4cd59e21e9f774a5c818 {get; set;}

	public virtual bool Propfdf7ba1facb4424db7424ff64aa43de9 {get; set;}

	public virtual string Prop28eb11e5ee2545a19d924efbeaf988c6 {get; set;}

	public virtual int Prope6e9955e84bf40f7b2c83055e80a2c46 {get; set;}

	public virtual string Prop70345ce3f45741eab138fce74f586af8 {get; set;}

	public virtual bool Propea4442b1057943f480ef66c2301a07cd {get; set;}

	public virtual bool Propdd78df36a537488fbd467ef038851322 {get; set;}

	public virtual bool Propc862b2f1b4964741b822c69df9b231b6 {get; set;}

	public virtual string Prop83108acda4114d9ab404a01da3512828 {get; set;}

	public virtual string Prop128f93a819484ef5bb6b8f331aebfc9f {get; set;}

	public virtual bool Prop60b72baaa16b4592b76d9505737e4216 {get; set;}

	public virtual string Prop69af65f2da9f499890b1e9dd6ba51361 {get; set;}

	public virtual bool Prop8b14ed42785147dbbde46ba580c86cdc {get; set;}

	public virtual string Propa362917c01884f22bc6c8294226285a8 {get; set;}

public static Class203fb173e4d0407c8a5093b52f9f3066 CreateWithRandomData()
{
	var x = new Class203fb173e4d0407c8a5093b52f9f3066();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propfd9859d6a3ce4e08a979ebb214de7cb3 = RndData.GetBool();
	x.Propd4d5511352094b67aba529e768af98f1 = RndData.GetString();
	x.Prop67fad365d13c43a280a0242cfbd3e3c5 = RndData.GetString();
	x.Propdcdee590c6994d6095c36fbfeaf9fe29 = RndData.GetString();
	x.Prop9e37bf6097c348f8a0e19e1a2b168704 = RndData.GetInt();
	x.Prop516883cbeb4a432facef5f11d01b68ae = RndData.GetString();
	x.Prop0e220fa2c0084612abe63257c84c6ac2 = RndData.GetInt();
	x.Propcb8f797a371e4de2ad491fc8a4e05c0e = RndData.GetInt();
	x.Prop3c27e8d640a940d4a40e45d4a8e644e3 = RndData.GetBool();
	x.Prop23bcef6d729f4f1b94513df7967c000d = RndData.GetBool();
	x.Propbb15b4e0258a4912bd919d101e3ce0f8 = RndData.GetBool();
	x.Prop5ccb6f2d4d5d4cd59e21e9f774a5c818 = RndData.GetInt();
	x.Propfdf7ba1facb4424db7424ff64aa43de9 = RndData.GetBool();
	x.Prop28eb11e5ee2545a19d924efbeaf988c6 = RndData.GetString();
	x.Prope6e9955e84bf40f7b2c83055e80a2c46 = RndData.GetInt();
	x.Prop70345ce3f45741eab138fce74f586af8 = RndData.GetString();
	x.Propea4442b1057943f480ef66c2301a07cd = RndData.GetBool();
	x.Propdd78df36a537488fbd467ef038851322 = RndData.GetBool();
	x.Propc862b2f1b4964741b822c69df9b231b6 = RndData.GetBool();
	x.Prop83108acda4114d9ab404a01da3512828 = RndData.GetString();
	x.Prop128f93a819484ef5bb6b8f331aebfc9f = RndData.GetString();
	x.Prop60b72baaa16b4592b76d9505737e4216 = RndData.GetBool();
	x.Prop69af65f2da9f499890b1e9dd6ba51361 = RndData.GetString();
	x.Prop8b14ed42785147dbbde46ba580c86cdc = RndData.GetBool();
	x.Propa362917c01884f22bc6c8294226285a8 = RndData.GetString();
return x;
}
}

public class Classa1562329032c47bfbccac58a21fa782f : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop5d32e2bd17f44ae0806ab5115e92303e {get; set;}

	public virtual string Prop75fe98346bf642edb2de715edda42244 {get; set;}

	public virtual bool Prop14c988297da64f91b70ef2fe9b76186b {get; set;}

	public virtual bool Propb647b2626000493fae341598f0c6da16 {get; set;}

	public virtual int Prop18e932f7e10044e98ea367eece89ce5b {get; set;}

	public virtual string Propabb166c8f3fa42678c2a8e18e54375e7 {get; set;}

	public virtual int Prop39bbfcefa0844a8ba963cdbaf883a88f {get; set;}

	public virtual string Prop5d289725ee0c493480fdea7a6c48cddb {get; set;}

	public virtual string Prop5d5a2480f2084311b9f36b4616bbda4e {get; set;}

	public virtual string Propc8afd9f92e2943848d12b10fcebbbd15 {get; set;}

	public virtual string Prop88b644b4b8d440238e49bbde314a1a8e {get; set;}

	public virtual bool Prop726adbed78814cc7add5fed2963601ac {get; set;}

	public virtual bool Propc312b208e3e34587b89c410c0fb3d283 {get; set;}

	public virtual bool Prop2b2e183bab8e40ad93b73634d670a214 {get; set;}

	public virtual bool Prop44871d26e8f84eff92dfedbe79c2568d {get; set;}

	public virtual bool Prop9531bf7d63b14c609119d03212ffdd8e {get; set;}

	public virtual bool Propc1630845580a409e9595f184c79774ac {get; set;}

	public virtual string Prop2ddb9b8dfa194ab38c6c522754a4b9ff {get; set;}

public static Classa1562329032c47bfbccac58a21fa782f CreateWithRandomData()
{
	var x = new Classa1562329032c47bfbccac58a21fa782f();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop5d32e2bd17f44ae0806ab5115e92303e = RndData.GetString();
	x.Prop75fe98346bf642edb2de715edda42244 = RndData.GetString();
	x.Prop14c988297da64f91b70ef2fe9b76186b = RndData.GetBool();
	x.Propb647b2626000493fae341598f0c6da16 = RndData.GetBool();
	x.Prop18e932f7e10044e98ea367eece89ce5b = RndData.GetInt();
	x.Propabb166c8f3fa42678c2a8e18e54375e7 = RndData.GetString();
	x.Prop39bbfcefa0844a8ba963cdbaf883a88f = RndData.GetInt();
	x.Prop5d289725ee0c493480fdea7a6c48cddb = RndData.GetString();
	x.Prop5d5a2480f2084311b9f36b4616bbda4e = RndData.GetString();
	x.Propc8afd9f92e2943848d12b10fcebbbd15 = RndData.GetString();
	x.Prop88b644b4b8d440238e49bbde314a1a8e = RndData.GetString();
	x.Prop726adbed78814cc7add5fed2963601ac = RndData.GetBool();
	x.Propc312b208e3e34587b89c410c0fb3d283 = RndData.GetBool();
	x.Prop2b2e183bab8e40ad93b73634d670a214 = RndData.GetBool();
	x.Prop44871d26e8f84eff92dfedbe79c2568d = RndData.GetBool();
	x.Prop9531bf7d63b14c609119d03212ffdd8e = RndData.GetBool();
	x.Propc1630845580a409e9595f184c79774ac = RndData.GetBool();
	x.Prop2ddb9b8dfa194ab38c6c522754a4b9ff = RndData.GetString();
return x;
}
}

public class Classd6116ec6de184589937ee9856403d182 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop35b839bbc4d14c7f99ae662183f05656 {get; set;}

	public virtual int Prop0df38381b4b9427e99f9a2fdffb67e6d {get; set;}

	public virtual bool Prop423eca0f155949068934e518b5419607 {get; set;}

	public virtual bool Prop7882fac16d584c99ad6282583c63c133 {get; set;}

	public virtual int Prope82ab00275f24f658c811be40c681c4c {get; set;}

	public virtual int Prop36cb91a291d04a4f873af2980adc72f4 {get; set;}

	public virtual string Prop1f23e4ffce2947b2a0e97b2c24b46cc8 {get; set;}

	public virtual string Prop62469ea4f4c84e43a08ac3dcc190f41a {get; set;}

	public virtual string Propd5f5c0951d6244169097310077d0b1e7 {get; set;}

	public virtual bool Prop34c5e3ebfd48434badb058b1cd490915 {get; set;}

	public virtual bool Propedacfafdab5c4fe18971bacc999c7c22 {get; set;}

	public virtual bool Prop31137e0fad8f4db7ba5de350fc7db7d1 {get; set;}

	public virtual bool Prop173e18eb0a70455ebe22452d07a8b0fe {get; set;}

	public virtual bool Propc9fa3ff208774a08b0dee1e19435ea8b {get; set;}

	public virtual bool Prop2ace448e385b4821ac15f2dc786ba6e0 {get; set;}

public static Classd6116ec6de184589937ee9856403d182 CreateWithRandomData()
{
	var x = new Classd6116ec6de184589937ee9856403d182();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop35b839bbc4d14c7f99ae662183f05656 = RndData.GetInt();
	x.Prop0df38381b4b9427e99f9a2fdffb67e6d = RndData.GetInt();
	x.Prop423eca0f155949068934e518b5419607 = RndData.GetBool();
	x.Prop7882fac16d584c99ad6282583c63c133 = RndData.GetBool();
	x.Prope82ab00275f24f658c811be40c681c4c = RndData.GetInt();
	x.Prop36cb91a291d04a4f873af2980adc72f4 = RndData.GetInt();
	x.Prop1f23e4ffce2947b2a0e97b2c24b46cc8 = RndData.GetString();
	x.Prop62469ea4f4c84e43a08ac3dcc190f41a = RndData.GetString();
	x.Propd5f5c0951d6244169097310077d0b1e7 = RndData.GetString();
	x.Prop34c5e3ebfd48434badb058b1cd490915 = RndData.GetBool();
	x.Propedacfafdab5c4fe18971bacc999c7c22 = RndData.GetBool();
	x.Prop31137e0fad8f4db7ba5de350fc7db7d1 = RndData.GetBool();
	x.Prop173e18eb0a70455ebe22452d07a8b0fe = RndData.GetBool();
	x.Propc9fa3ff208774a08b0dee1e19435ea8b = RndData.GetBool();
	x.Prop2ace448e385b4821ac15f2dc786ba6e0 = RndData.GetBool();
return x;
}
}

public class Classdb291af8c4a54e819448c85e40563dbf : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Propa5626cbeb75048628ee1fae181b62523 {get; set;}

	public virtual bool Prop2b2fdfbc186140b094efc5038a5cf04b {get; set;}

	public virtual bool Prop7f045f82a0ec4984ad01e3246c32281e {get; set;}

	public virtual string Prop9e3592e72d714298ad9dbdb84bb1f0dc {get; set;}

	public virtual bool Prop07bd366ea090490c9fdd1ba41aa147c6 {get; set;}

	public virtual string Propc204010c159f4da8ba1f76ccd21c6fa3 {get; set;}

	public virtual int Propaaf4f3ea8e5146f5bbc22f81f143d4d5 {get; set;}

	public virtual string Propddd78d16c6ef4dc6b8a68430fe419cf6 {get; set;}

	public virtual int Prop88aed5cbfa7f40df9d9450340763ed2f {get; set;}

	public virtual string Propa6965c28339b4785b1e1dbcf61aea522 {get; set;}

	public virtual int Prop819d5384e66c40a689d2b4ca8384582a {get; set;}

public static Classdb291af8c4a54e819448c85e40563dbf CreateWithRandomData()
{
	var x = new Classdb291af8c4a54e819448c85e40563dbf();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propa5626cbeb75048628ee1fae181b62523 = RndData.GetBool();
	x.Prop2b2fdfbc186140b094efc5038a5cf04b = RndData.GetBool();
	x.Prop7f045f82a0ec4984ad01e3246c32281e = RndData.GetBool();
	x.Prop9e3592e72d714298ad9dbdb84bb1f0dc = RndData.GetString();
	x.Prop07bd366ea090490c9fdd1ba41aa147c6 = RndData.GetBool();
	x.Propc204010c159f4da8ba1f76ccd21c6fa3 = RndData.GetString();
	x.Propaaf4f3ea8e5146f5bbc22f81f143d4d5 = RndData.GetInt();
	x.Propddd78d16c6ef4dc6b8a68430fe419cf6 = RndData.GetString();
	x.Prop88aed5cbfa7f40df9d9450340763ed2f = RndData.GetInt();
	x.Propa6965c28339b4785b1e1dbcf61aea522 = RndData.GetString();
	x.Prop819d5384e66c40a689d2b4ca8384582a = RndData.GetInt();
return x;
}
}

public class Classc555367b57f9489cbfb12cd63e2c13c7 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop751ed77e597042b088d1a196b562e637 {get; set;}

	public virtual ICollection<Classfb5ce1f050a6403dbe9b7a08635ec78a> Propc23d369af7e54d7192348200785488a8 {get; set;}

	public virtual string Propda5a77ec442c45ad925af25ea3a62fce {get; set;}

	public virtual int Prop6544e4f3470146e4a508e2880249a6e3 {get; set;}

	public virtual bool Prop789e6b2fd8e543da83bb04df1df87328 {get; set;}

	public virtual bool Prop5200b992a6fa4686b5891790755ad649 {get; set;}

	public virtual int Propa283d64a106a4390853fe2dc5cf3378e {get; set;}

	public virtual string Prop1f4225476f1e43a2a129d27ac82448f8 {get; set;}

	public virtual bool Propf9014d77a85c42e48fd688f3d35cb3fe {get; set;}

	public virtual bool Prop733ff6a3c6ef4647a1f6764891d87754 {get; set;}

	public virtual int Prop8f9c36c601134d3a81ce8d28c0d0f683 {get; set;}

	public virtual string Prop7de2e5f999924918975d0e62276cd70c {get; set;}

	public virtual bool Prop2c8db5b936574549b218ef5af90c5336 {get; set;}

	public virtual Class09f335ee290547559b132a24995aae5c Propc1610570c7c64c648085f5a1f735314d {get; set;}

	public virtual bool Prope310bddc098c48929682ca27d5ca2782 {get; set;}

public static Classc555367b57f9489cbfb12cd63e2c13c7 CreateWithRandomData()
{
	var x = new Classc555367b57f9489cbfb12cd63e2c13c7();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop751ed77e597042b088d1a196b562e637 = RndData.GetInt();
	x.Propc23d369af7e54d7192348200785488a8 = new List<Classfb5ce1f050a6403dbe9b7a08635ec78a>(RndData.GetList(10, Classfb5ce1f050a6403dbe9b7a08635ec78a.CreateWithRandomData));
	x.Propda5a77ec442c45ad925af25ea3a62fce = RndData.GetString();
	x.Prop6544e4f3470146e4a508e2880249a6e3 = RndData.GetInt();
	x.Prop789e6b2fd8e543da83bb04df1df87328 = RndData.GetBool();
	x.Prop5200b992a6fa4686b5891790755ad649 = RndData.GetBool();
	x.Propa283d64a106a4390853fe2dc5cf3378e = RndData.GetInt();
	x.Prop1f4225476f1e43a2a129d27ac82448f8 = RndData.GetString();
	x.Propf9014d77a85c42e48fd688f3d35cb3fe = RndData.GetBool();
	x.Prop733ff6a3c6ef4647a1f6764891d87754 = RndData.GetBool();
	x.Prop8f9c36c601134d3a81ce8d28c0d0f683 = RndData.GetInt();
	x.Prop7de2e5f999924918975d0e62276cd70c = RndData.GetString();
	x.Prop2c8db5b936574549b218ef5af90c5336 = RndData.GetBool();
	x.Propc1610570c7c64c648085f5a1f735314d = Class09f335ee290547559b132a24995aae5c.CreateWithRandomData();
	x.Prope310bddc098c48929682ca27d5ca2782 = RndData.GetBool();
return x;
}
}

public class Classfb5ce1f050a6403dbe9b7a08635ec78a : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop98eb753f85eb4d05bac273bece5e3e3a {get; set;}

	public virtual int Prop613826e02e214df6a01a223004f09f24 {get; set;}

	public virtual string Propf848125883914b6aa90cb952974edd1f {get; set;}

	public virtual int Propb95070e2c3da440ea7da736da6c90f03 {get; set;}

	public virtual bool Propd0137caf6c5d4ef4a1ffa40db24cf6d7 {get; set;}

	public virtual bool Prop7aa4612c9acd4143814cd6ad4e8a8dd4 {get; set;}

	public virtual string Prop9eb1fc8bd5664b61901a624b88973dcf {get; set;}

	public virtual bool Propd0d16c0b565c4ead806115931c818ea5 {get; set;}

	public virtual string Prop80c4abe5e95744d2bd831fb29022c8a0 {get; set;}

	public virtual ICollection<Classc21d526f79304ce7bc4bde110fd4f606> Prop758de2b7b466497aa559ff2cd2a66ea7 {get; set;}

	public virtual bool Prop007e54570bdd4b3b9a2cea49394761b8 {get; set;}

	public virtual bool Prop45e7234908d442939ebbc87090e57f48 {get; set;}

	public virtual int Prop800fc2179ced406fb19a751558fa0ac7 {get; set;}

	public virtual int Prop4e846008568d4e1aabc40ed31f1b40e6 {get; set;}

	public virtual bool Prop49b5d0b89ac046bb8b8d394fd15ff40f {get; set;}

	public virtual bool Prop18b84f9dda3f4252a6c7a4188eac1022 {get; set;}

	public virtual bool Prop60a6a08280d640a2b3d7c1aa157dccdb {get; set;}

	public virtual int Prope5a67b79a0aa4643b3a552024fc280c1 {get; set;}

	public virtual Classfa70f72a95044bfc8d7ab73da8f8a584 Propd1459eb92e9b45c4b5ae0dcefdd6eb99 {get; set;}

public static Classfb5ce1f050a6403dbe9b7a08635ec78a CreateWithRandomData()
{
	var x = new Classfb5ce1f050a6403dbe9b7a08635ec78a();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop98eb753f85eb4d05bac273bece5e3e3a = RndData.GetString();
	x.Prop613826e02e214df6a01a223004f09f24 = RndData.GetInt();
	x.Propf848125883914b6aa90cb952974edd1f = RndData.GetString();
	x.Propb95070e2c3da440ea7da736da6c90f03 = RndData.GetInt();
	x.Propd0137caf6c5d4ef4a1ffa40db24cf6d7 = RndData.GetBool();
	x.Prop7aa4612c9acd4143814cd6ad4e8a8dd4 = RndData.GetBool();
	x.Prop9eb1fc8bd5664b61901a624b88973dcf = RndData.GetString();
	x.Propd0d16c0b565c4ead806115931c818ea5 = RndData.GetBool();
	x.Prop80c4abe5e95744d2bd831fb29022c8a0 = RndData.GetString();
	x.Prop758de2b7b466497aa559ff2cd2a66ea7 = new List<Classc21d526f79304ce7bc4bde110fd4f606>(RndData.GetList(10, Classc21d526f79304ce7bc4bde110fd4f606.CreateWithRandomData));
	x.Prop007e54570bdd4b3b9a2cea49394761b8 = RndData.GetBool();
	x.Prop45e7234908d442939ebbc87090e57f48 = RndData.GetBool();
	x.Prop800fc2179ced406fb19a751558fa0ac7 = RndData.GetInt();
	x.Prop4e846008568d4e1aabc40ed31f1b40e6 = RndData.GetInt();
	x.Prop49b5d0b89ac046bb8b8d394fd15ff40f = RndData.GetBool();
	x.Prop18b84f9dda3f4252a6c7a4188eac1022 = RndData.GetBool();
	x.Prop60a6a08280d640a2b3d7c1aa157dccdb = RndData.GetBool();
	x.Prope5a67b79a0aa4643b3a552024fc280c1 = RndData.GetInt();
	x.Propd1459eb92e9b45c4b5ae0dcefdd6eb99 = Classfa70f72a95044bfc8d7ab73da8f8a584.CreateWithRandomData();
return x;
}
}

public class Classc21d526f79304ce7bc4bde110fd4f606 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop32ab68afb9644222a970d397beb1575f {get; set;}

	public virtual bool Prop37145eb3cdca4f0abd727312b946362d {get; set;}

	public virtual bool Prop4d6d77228e074dc6832f82b9f502e7f9 {get; set;}

	public virtual bool Prop9e4090017ee942f0bad2e20bc3096035 {get; set;}

	public virtual int Propeead8308f6204c578c14f8e77f5d2c86 {get; set;}

	public virtual int Prop9371b132a3aa4ca4b8d6ca235e596433 {get; set;}

	public virtual bool Propedf1253db26441b8aa162e9db50d5bf2 {get; set;}

	public virtual int Propcc67ce1550784752bc9d9b3aef9cf49e {get; set;}

	public virtual int Propdaa8b25c08aa4fc68f676f7e0ddfbd42 {get; set;}

	public virtual bool Prop6a680ad6fdb242b5bd437ffec9d09840 {get; set;}

	public virtual int Prop2c22f29b366a4a99ab264c2d360df4bf {get; set;}

	public virtual int Propa5e48d6edf9d4768a1cbda92b6910311 {get; set;}

	public virtual int Prop86df30eea6e7455b98760447bc35632d {get; set;}

	public virtual int Prop9d508c3b8e6e4c67b8cac939f55b8acd {get; set;}

	public virtual bool Prop990bd9f0e9ae478aafdd8218c355e8ae {get; set;}

	public virtual int Prop19656fea632b496892b8e9029f3a4083 {get; set;}

	public virtual string Prop9ac4f255b20c48b9af111c861c633f1c {get; set;}

	public virtual string Propf38fbfafed034a14b9c019f128a359d5 {get; set;}

	public virtual string Prop5033f62fab1548dda10641575de54eed {get; set;}

	public virtual string Prop4f3adf3105134b15a6c665eee889160a {get; set;}

	public virtual string Propd95bb45af3c74fb0848ac6705e0b3afd {get; set;}

	public virtual bool Prop60dfa3d33fcb4bd3b435c4a708bf9515 {get; set;}

	public virtual int Propf5260a2a2fb841779d76c29302d358b5 {get; set;}

public static Classc21d526f79304ce7bc4bde110fd4f606 CreateWithRandomData()
{
	var x = new Classc21d526f79304ce7bc4bde110fd4f606();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop32ab68afb9644222a970d397beb1575f = RndData.GetBool();
	x.Prop37145eb3cdca4f0abd727312b946362d = RndData.GetBool();
	x.Prop4d6d77228e074dc6832f82b9f502e7f9 = RndData.GetBool();
	x.Prop9e4090017ee942f0bad2e20bc3096035 = RndData.GetBool();
	x.Propeead8308f6204c578c14f8e77f5d2c86 = RndData.GetInt();
	x.Prop9371b132a3aa4ca4b8d6ca235e596433 = RndData.GetInt();
	x.Propedf1253db26441b8aa162e9db50d5bf2 = RndData.GetBool();
	x.Propcc67ce1550784752bc9d9b3aef9cf49e = RndData.GetInt();
	x.Propdaa8b25c08aa4fc68f676f7e0ddfbd42 = RndData.GetInt();
	x.Prop6a680ad6fdb242b5bd437ffec9d09840 = RndData.GetBool();
	x.Prop2c22f29b366a4a99ab264c2d360df4bf = RndData.GetInt();
	x.Propa5e48d6edf9d4768a1cbda92b6910311 = RndData.GetInt();
	x.Prop86df30eea6e7455b98760447bc35632d = RndData.GetInt();
	x.Prop9d508c3b8e6e4c67b8cac939f55b8acd = RndData.GetInt();
	x.Prop990bd9f0e9ae478aafdd8218c355e8ae = RndData.GetBool();
	x.Prop19656fea632b496892b8e9029f3a4083 = RndData.GetInt();
	x.Prop9ac4f255b20c48b9af111c861c633f1c = RndData.GetString();
	x.Propf38fbfafed034a14b9c019f128a359d5 = RndData.GetString();
	x.Prop5033f62fab1548dda10641575de54eed = RndData.GetString();
	x.Prop4f3adf3105134b15a6c665eee889160a = RndData.GetString();
	x.Propd95bb45af3c74fb0848ac6705e0b3afd = RndData.GetString();
	x.Prop60dfa3d33fcb4bd3b435c4a708bf9515 = RndData.GetBool();
	x.Propf5260a2a2fb841779d76c29302d358b5 = RndData.GetInt();
return x;
}
}

public class Classfa70f72a95044bfc8d7ab73da8f8a584 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Propc54bf8b2ce1744088fbc60958ae77f40 {get; set;}

	public virtual string Propc3d7a5502fef4f8e9c3b45f34a539288 {get; set;}

	public virtual string Propee1ba923abfb4101a09162edc930caaf {get; set;}

	public virtual string Prop75b26c4a02e9471b80ecfd0b3e712b25 {get; set;}

	public virtual int Prop7d01bc82b1844e3389f294790d486812 {get; set;}

	public virtual int Prop206366f18e3e497fa681b88272f843ec {get; set;}

	public virtual int Prope5d48b0c427e408db6e898f41a3e2b66 {get; set;}

	public virtual int Prop5ac66013451d40419524ed00daaa222b {get; set;}

	public virtual string Prop8003620d078347358a6da0dc8669b4f6 {get; set;}

	public virtual int Propd16740afa31b4711ba34febe16b38236 {get; set;}

	public virtual bool Prop8e40ea062a1d40e89d8323a13dcef00b {get; set;}

	public virtual bool Prop56951aec2bd5408a90df3a1617edaa25 {get; set;}

	public virtual string Prop74b6f1193fb84a628bbad3816ffbf2ea {get; set;}

	public virtual bool Propaf51da74158542588a2856a6994f7aaf {get; set;}

	public virtual int Propa749d9b082cb4522ac0cc5a0ca177d17 {get; set;}

	public virtual int Prop7d9f151ccd374ce8b0ca86683e8f0896 {get; set;}

	public virtual int Prop9dba63ba822b490999b0b07a09ff9841 {get; set;}

	public virtual int Prop7a2d2c6cd312439d8cbb4ab74c1b98f8 {get; set;}

	public virtual int Propdc03eca6d6e24740a868579ce13a9c71 {get; set;}

	public virtual int Prop6a97684b7a794c80ba558ffdcbcbddd1 {get; set;}

	public virtual bool Propf435b115194b4fe9820486f1e82fb048 {get; set;}

	public virtual int Prop07dd373ac4074170b1b418d576458e83 {get; set;}

	public virtual int Prop09083a13bfd34bd5b8002c13844db095 {get; set;}

	public virtual string Prop54b74e90d0f94f6baba47dc70380c418 {get; set;}

public static Classfa70f72a95044bfc8d7ab73da8f8a584 CreateWithRandomData()
{
	var x = new Classfa70f72a95044bfc8d7ab73da8f8a584();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propc54bf8b2ce1744088fbc60958ae77f40 = RndData.GetString();
	x.Propc3d7a5502fef4f8e9c3b45f34a539288 = RndData.GetString();
	x.Propee1ba923abfb4101a09162edc930caaf = RndData.GetString();
	x.Prop75b26c4a02e9471b80ecfd0b3e712b25 = RndData.GetString();
	x.Prop7d01bc82b1844e3389f294790d486812 = RndData.GetInt();
	x.Prop206366f18e3e497fa681b88272f843ec = RndData.GetInt();
	x.Prope5d48b0c427e408db6e898f41a3e2b66 = RndData.GetInt();
	x.Prop5ac66013451d40419524ed00daaa222b = RndData.GetInt();
	x.Prop8003620d078347358a6da0dc8669b4f6 = RndData.GetString();
	x.Propd16740afa31b4711ba34febe16b38236 = RndData.GetInt();
	x.Prop8e40ea062a1d40e89d8323a13dcef00b = RndData.GetBool();
	x.Prop56951aec2bd5408a90df3a1617edaa25 = RndData.GetBool();
	x.Prop74b6f1193fb84a628bbad3816ffbf2ea = RndData.GetString();
	x.Propaf51da74158542588a2856a6994f7aaf = RndData.GetBool();
	x.Propa749d9b082cb4522ac0cc5a0ca177d17 = RndData.GetInt();
	x.Prop7d9f151ccd374ce8b0ca86683e8f0896 = RndData.GetInt();
	x.Prop9dba63ba822b490999b0b07a09ff9841 = RndData.GetInt();
	x.Prop7a2d2c6cd312439d8cbb4ab74c1b98f8 = RndData.GetInt();
	x.Propdc03eca6d6e24740a868579ce13a9c71 = RndData.GetInt();
	x.Prop6a97684b7a794c80ba558ffdcbcbddd1 = RndData.GetInt();
	x.Propf435b115194b4fe9820486f1e82fb048 = RndData.GetBool();
	x.Prop07dd373ac4074170b1b418d576458e83 = RndData.GetInt();
	x.Prop09083a13bfd34bd5b8002c13844db095 = RndData.GetInt();
	x.Prop54b74e90d0f94f6baba47dc70380c418 = RndData.GetString();
return x;
}
}

public class Class09f335ee290547559b132a24995aae5c : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop455c9a1cf8dc425caab283d22b8b964a {get; set;}

	public virtual int Prop67ee939dcaa84be9934b0d750aec5e46 {get; set;}

	public virtual int Propaa359125626d4d62894d37029a98a2c7 {get; set;}

	public virtual bool Prop8894605056fa465392f0974d22d0b503 {get; set;}

	public virtual bool Propabe48a38e24f48e9acc64ea51fefd169 {get; set;}

	public virtual string Propfcd7fc3471eb43f0a82eceffc9d9d59e {get; set;}

	public virtual bool Propdfb58387f0054d6aa57f82110af8f5d7 {get; set;}

	public virtual bool Prop679942415954479fa5046439fc34ad12 {get; set;}

	public virtual string Propa54bc5e7d5f44efda68b83b42316cbfb {get; set;}

	public virtual string Propb0c431289f614db4acc6155950e7f3be {get; set;}

	public virtual string Prop3d6b9aa9b47243d8b180fdfda2f2f6cd {get; set;}

	public virtual int Prop6b00588ca0754d10be1aad1829b38966 {get; set;}

	public virtual bool Prop8863fe52d90e44ec812172b98fae5695 {get; set;}

	public virtual string Proped0621d5f5bc452885bb515764be37dc {get; set;}

	public virtual int Prop7876d283d7a54a61bc1feaf8485510c2 {get; set;}

	public virtual int Prop940f4858d68f4aae8cc5ae76b28a9caa {get; set;}

public static Class09f335ee290547559b132a24995aae5c CreateWithRandomData()
{
	var x = new Class09f335ee290547559b132a24995aae5c();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop455c9a1cf8dc425caab283d22b8b964a = RndData.GetBool();
	x.Prop67ee939dcaa84be9934b0d750aec5e46 = RndData.GetInt();
	x.Propaa359125626d4d62894d37029a98a2c7 = RndData.GetInt();
	x.Prop8894605056fa465392f0974d22d0b503 = RndData.GetBool();
	x.Propabe48a38e24f48e9acc64ea51fefd169 = RndData.GetBool();
	x.Propfcd7fc3471eb43f0a82eceffc9d9d59e = RndData.GetString();
	x.Propdfb58387f0054d6aa57f82110af8f5d7 = RndData.GetBool();
	x.Prop679942415954479fa5046439fc34ad12 = RndData.GetBool();
	x.Propa54bc5e7d5f44efda68b83b42316cbfb = RndData.GetString();
	x.Propb0c431289f614db4acc6155950e7f3be = RndData.GetString();
	x.Prop3d6b9aa9b47243d8b180fdfda2f2f6cd = RndData.GetString();
	x.Prop6b00588ca0754d10be1aad1829b38966 = RndData.GetInt();
	x.Prop8863fe52d90e44ec812172b98fae5695 = RndData.GetBool();
	x.Proped0621d5f5bc452885bb515764be37dc = RndData.GetString();
	x.Prop7876d283d7a54a61bc1feaf8485510c2 = RndData.GetInt();
	x.Prop940f4858d68f4aae8cc5ae76b28a9caa = RndData.GetInt();
return x;
}
}

public class Class50791ff63b0b4d1ba8f72f6e94db59cb : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Propce53dd0ca9864b119ed7f25330249634 {get; set;}

	public virtual string Prop8aac597c95154c40b552b067c91aab5e {get; set;}

	public virtual string Prop6422f6ebc686421396f89cb1cccb9011 {get; set;}

	public virtual string Prop8747b8c1502f477e993b3db14884b71d {get; set;}

	public virtual bool Prop53ef42631c9a4c2b9da9be585c9947d9 {get; set;}

	public virtual bool Propb721ade6e99c421fb3db113894562bbc {get; set;}

	public virtual int Prop9d27098c24a84c47ab9c6d06194212bb {get; set;}

	public virtual int Prop41db4fcf29e942758530aee4a2216b5c {get; set;}

	public virtual ICollection<Classc67d15c042944a47b27c5649c0b314b0> Prop135fbc364a4d417f94baf0cd21f101bf {get; set;}

	public virtual int Propcbe14671e40e4411adf9803e34358cf7 {get; set;}

	public virtual bool Prop246fb2b8482848d9b5026aeb50b1af7b {get; set;}

	public virtual string Prop163bd5a32d3146a39015ef8b53f62162 {get; set;}

	public virtual bool Propab5565557ffa4fd293a081cc55ef1d19 {get; set;}

	public virtual string Prop8a8d9e91b24b4d638bc09bf4324ecbe4 {get; set;}

	public virtual int Prop2c86a6173dca4c1f9f0fd0a035b879ec {get; set;}

	public virtual int Prop9a57cb4d6f39436194c57e2ea8824ce7 {get; set;}

	public virtual string Prop8e09650db93141e18f0076c8151b90e0 {get; set;}

public static Class50791ff63b0b4d1ba8f72f6e94db59cb CreateWithRandomData()
{
	var x = new Class50791ff63b0b4d1ba8f72f6e94db59cb();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propce53dd0ca9864b119ed7f25330249634 = RndData.GetString();
	x.Prop8aac597c95154c40b552b067c91aab5e = RndData.GetString();
	x.Prop6422f6ebc686421396f89cb1cccb9011 = RndData.GetString();
	x.Prop8747b8c1502f477e993b3db14884b71d = RndData.GetString();
	x.Prop53ef42631c9a4c2b9da9be585c9947d9 = RndData.GetBool();
	x.Propb721ade6e99c421fb3db113894562bbc = RndData.GetBool();
	x.Prop9d27098c24a84c47ab9c6d06194212bb = RndData.GetInt();
	x.Prop41db4fcf29e942758530aee4a2216b5c = RndData.GetInt();
	x.Prop135fbc364a4d417f94baf0cd21f101bf = new List<Classc67d15c042944a47b27c5649c0b314b0>(RndData.GetList(10, Classc67d15c042944a47b27c5649c0b314b0.CreateWithRandomData));
	x.Propcbe14671e40e4411adf9803e34358cf7 = RndData.GetInt();
	x.Prop246fb2b8482848d9b5026aeb50b1af7b = RndData.GetBool();
	x.Prop163bd5a32d3146a39015ef8b53f62162 = RndData.GetString();
	x.Propab5565557ffa4fd293a081cc55ef1d19 = RndData.GetBool();
	x.Prop8a8d9e91b24b4d638bc09bf4324ecbe4 = RndData.GetString();
	x.Prop2c86a6173dca4c1f9f0fd0a035b879ec = RndData.GetInt();
	x.Prop9a57cb4d6f39436194c57e2ea8824ce7 = RndData.GetInt();
	x.Prop8e09650db93141e18f0076c8151b90e0 = RndData.GetString();
return x;
}
}

public class Classc67d15c042944a47b27c5649c0b314b0 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop803440afc3a4497e959b503c73cf297a {get; set;}

	public virtual string Propca21f82206d74c36a8342ea8641728c4 {get; set;}

	public virtual bool Propa885dd002fff42e393b40331497c8bfa {get; set;}

	public virtual int Propc5bc217f023a49da8f94f201d59838ef {get; set;}

	public virtual Class0e8a7daa74ed4ea5a0924fb32c63e937 Prop0b7b14457ef2492d9967383e3886454d {get; set;}

	public virtual Class2c1cab53a8c2487181d19d596514c9ae Propd6ee4db6c14a45e88585a34be7b16beb {get; set;}

	public virtual bool Propc8b521d294ef4f21ac308cf57b6f8940 {get; set;}

	public virtual string Propfa78d231eda64937b5bcc71ca96bd94d {get; set;}

	public virtual string Prop3d6fcc68f74f4bfb9443a11a32e98ee4 {get; set;}

	public virtual bool Propf0c77ec4d05743bfb835f430883350e4 {get; set;}

	public virtual ICollection<Class84c63fd599ee4cb297c068aa63072517> Prop5c47d46d75ff45ddbd17263ed966c4d9 {get; set;}

public static Classc67d15c042944a47b27c5649c0b314b0 CreateWithRandomData()
{
	var x = new Classc67d15c042944a47b27c5649c0b314b0();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop803440afc3a4497e959b503c73cf297a = RndData.GetString();
	x.Propca21f82206d74c36a8342ea8641728c4 = RndData.GetString();
	x.Propa885dd002fff42e393b40331497c8bfa = RndData.GetBool();
	x.Propc5bc217f023a49da8f94f201d59838ef = RndData.GetInt();
	x.Prop0b7b14457ef2492d9967383e3886454d = Class0e8a7daa74ed4ea5a0924fb32c63e937.CreateWithRandomData();
	x.Propd6ee4db6c14a45e88585a34be7b16beb = Class2c1cab53a8c2487181d19d596514c9ae.CreateWithRandomData();
	x.Propc8b521d294ef4f21ac308cf57b6f8940 = RndData.GetBool();
	x.Propfa78d231eda64937b5bcc71ca96bd94d = RndData.GetString();
	x.Prop3d6fcc68f74f4bfb9443a11a32e98ee4 = RndData.GetString();
	x.Propf0c77ec4d05743bfb835f430883350e4 = RndData.GetBool();
	x.Prop5c47d46d75ff45ddbd17263ed966c4d9 = new List<Class84c63fd599ee4cb297c068aa63072517>(RndData.GetList(10, Class84c63fd599ee4cb297c068aa63072517.CreateWithRandomData));
return x;
}
}

public class Class0e8a7daa74ed4ea5a0924fb32c63e937 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop8d0bfb7fa6bd4da9893909b12b3cb2f9 {get; set;}

	public virtual string Prop42527bb1e2514395b6c53216857c3a4a {get; set;}

	public virtual int Prop056c889de6e74a8a8e6a9e191cb0aced {get; set;}

	public virtual bool Prop3342c8f1c3a54731b2c26367fd04d93e {get; set;}

	public virtual int Prop7634b06d7fc6429e95984dc32dc100ac {get; set;}

	public virtual bool Propae3c2b7144124f88a1ac9a51c0ceb19a {get; set;}

	public virtual bool Prop403a2dd6f9094b739b7c89a314518f53 {get; set;}

	public virtual bool Prop8ecc87617aa847bb9a12b2f482ae4404 {get; set;}

	public virtual int Propff664fcc244c4a6dab642e88ce271125 {get; set;}

	public virtual bool Propd40d88fe966c4865813c73b88a205177 {get; set;}

	public virtual bool Prop4f6ddbdcf926465fb2151094427a88a3 {get; set;}

	public virtual int Prop379deac208d848518a9b88efeee03d71 {get; set;}

	public virtual string Prop617f1a65a2e24b928ec459391d90aee8 {get; set;}

	public virtual int Propaf453a5a8cc7452db97b16e374cd9b27 {get; set;}

	public virtual int Prop0903dbd62d694393a9be7ee7f03d3b52 {get; set;}

	public virtual int Prop20a3cad516d34bbf9eba4a4e4fa3102d {get; set;}

	public virtual bool Propcad445fe2895448a914433d5f6582aa2 {get; set;}

	public virtual int Prop01e5dbc555fd43e4b9683b98402df896 {get; set;}

	public virtual bool Propcdfaffa4fa6243bf8b4b3732eadcce41 {get; set;}

	public virtual bool Prop88f1b679bdaa4775bf2e6ed1514472f4 {get; set;}

	public virtual int Prop9355729ad2ba4d4b93999f838746aad2 {get; set;}

	public virtual string Prop3676e26d8a9740c6b27fb1969bc43dff {get; set;}

	public virtual int Prop359479b09d4f4efab464e11eece4a625 {get; set;}

	public virtual bool Propc65e3fbe6d4e40d9a39cc5eeb1423884 {get; set;}

	public virtual bool Propb98fb51def30436594d0470b605df99e {get; set;}

	public virtual int Propd096ff21c86b41bd915a624eade15190 {get; set;}

	public virtual bool Prop660bd95daa274dac81b39ddc02fe50fe {get; set;}

	public virtual int Prop78af6637e5be46b383f74204077a60d2 {get; set;}

	public virtual int Prop304fc5a2926445c4bb06993897314778 {get; set;}

	public virtual string Prop80aba3e63def47339183fc94d2f82adb {get; set;}

public static Class0e8a7daa74ed4ea5a0924fb32c63e937 CreateWithRandomData()
{
	var x = new Class0e8a7daa74ed4ea5a0924fb32c63e937();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop8d0bfb7fa6bd4da9893909b12b3cb2f9 = RndData.GetString();
	x.Prop42527bb1e2514395b6c53216857c3a4a = RndData.GetString();
	x.Prop056c889de6e74a8a8e6a9e191cb0aced = RndData.GetInt();
	x.Prop3342c8f1c3a54731b2c26367fd04d93e = RndData.GetBool();
	x.Prop7634b06d7fc6429e95984dc32dc100ac = RndData.GetInt();
	x.Propae3c2b7144124f88a1ac9a51c0ceb19a = RndData.GetBool();
	x.Prop403a2dd6f9094b739b7c89a314518f53 = RndData.GetBool();
	x.Prop8ecc87617aa847bb9a12b2f482ae4404 = RndData.GetBool();
	x.Propff664fcc244c4a6dab642e88ce271125 = RndData.GetInt();
	x.Propd40d88fe966c4865813c73b88a205177 = RndData.GetBool();
	x.Prop4f6ddbdcf926465fb2151094427a88a3 = RndData.GetBool();
	x.Prop379deac208d848518a9b88efeee03d71 = RndData.GetInt();
	x.Prop617f1a65a2e24b928ec459391d90aee8 = RndData.GetString();
	x.Propaf453a5a8cc7452db97b16e374cd9b27 = RndData.GetInt();
	x.Prop0903dbd62d694393a9be7ee7f03d3b52 = RndData.GetInt();
	x.Prop20a3cad516d34bbf9eba4a4e4fa3102d = RndData.GetInt();
	x.Propcad445fe2895448a914433d5f6582aa2 = RndData.GetBool();
	x.Prop01e5dbc555fd43e4b9683b98402df896 = RndData.GetInt();
	x.Propcdfaffa4fa6243bf8b4b3732eadcce41 = RndData.GetBool();
	x.Prop88f1b679bdaa4775bf2e6ed1514472f4 = RndData.GetBool();
	x.Prop9355729ad2ba4d4b93999f838746aad2 = RndData.GetInt();
	x.Prop3676e26d8a9740c6b27fb1969bc43dff = RndData.GetString();
	x.Prop359479b09d4f4efab464e11eece4a625 = RndData.GetInt();
	x.Propc65e3fbe6d4e40d9a39cc5eeb1423884 = RndData.GetBool();
	x.Propb98fb51def30436594d0470b605df99e = RndData.GetBool();
	x.Propd096ff21c86b41bd915a624eade15190 = RndData.GetInt();
	x.Prop660bd95daa274dac81b39ddc02fe50fe = RndData.GetBool();
	x.Prop78af6637e5be46b383f74204077a60d2 = RndData.GetInt();
	x.Prop304fc5a2926445c4bb06993897314778 = RndData.GetInt();
	x.Prop80aba3e63def47339183fc94d2f82adb = RndData.GetString();
return x;
}
}

public class Class2c1cab53a8c2487181d19d596514c9ae : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop9ea77402830b4c15883b22203f8c6abb {get; set;}

	public virtual bool Prop35a3b89433804f51a5e05787956ef70f {get; set;}

	public virtual int Prop7642dfeaf36e48bbaae772ff5d6595c6 {get; set;}

	public virtual bool Prop15114716fdfd48dd886bce0bac4256ab {get; set;}

	public virtual int Prop885d7fd6060e48b191315c89e93948e4 {get; set;}

	public virtual string Propafcd562f59644747b55f4457652fd79c {get; set;}

	public virtual int Prop1b214badd3544e83a602859f729aea69 {get; set;}

	public virtual string Prop4cc3e9c9c29a4bd1b2d2e9c2c80bf976 {get; set;}

	public virtual string Prop3c05ecad9f02420b8a8a2d1174e60d53 {get; set;}

	public virtual int Propc9edbc71fdca4c00a3e47222e7028db4 {get; set;}

	public virtual int Prop74bdb9886b9b47f3926fe4e952e291db {get; set;}

public static Class2c1cab53a8c2487181d19d596514c9ae CreateWithRandomData()
{
	var x = new Class2c1cab53a8c2487181d19d596514c9ae();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop9ea77402830b4c15883b22203f8c6abb = RndData.GetBool();
	x.Prop35a3b89433804f51a5e05787956ef70f = RndData.GetBool();
	x.Prop7642dfeaf36e48bbaae772ff5d6595c6 = RndData.GetInt();
	x.Prop15114716fdfd48dd886bce0bac4256ab = RndData.GetBool();
	x.Prop885d7fd6060e48b191315c89e93948e4 = RndData.GetInt();
	x.Propafcd562f59644747b55f4457652fd79c = RndData.GetString();
	x.Prop1b214badd3544e83a602859f729aea69 = RndData.GetInt();
	x.Prop4cc3e9c9c29a4bd1b2d2e9c2c80bf976 = RndData.GetString();
	x.Prop3c05ecad9f02420b8a8a2d1174e60d53 = RndData.GetString();
	x.Propc9edbc71fdca4c00a3e47222e7028db4 = RndData.GetInt();
	x.Prop74bdb9886b9b47f3926fe4e952e291db = RndData.GetInt();
return x;
}
}

public class Class84c63fd599ee4cb297c068aa63072517 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop9e0d5d9c07424a5bacb2bed65b46097b {get; set;}

	public virtual int Prop4bd679a5269740cc8d0d36b173e74099 {get; set;}

	public virtual string Prope09286e6f9f44807a71197412d87659f {get; set;}

	public virtual int Prop8e5600ae97c344f6ab555821c769eeb5 {get; set;}

	public virtual bool Propfbaee59bc785406ca964f98d1fca576a {get; set;}

	public virtual int Propcd81af0ed2804421bef6392226f4d3e6 {get; set;}

	public virtual bool Prop1f0a433ce7ac4d8cbc910e913b751f3b {get; set;}

	public virtual int Prop03f2fa5b664e4d04a6db59a84125aa01 {get; set;}

	public virtual int Propdade7ffff7ac460682e8d217cfb6aedf {get; set;}

	public virtual string Prop29bab4dc340942688c1b54f683848aed {get; set;}

	public virtual bool Propdec87f4ab5964196bc9cc9f6e2b30f3f {get; set;}

	public virtual string Propd524d4952ddd4b08be4aaba32a4748d6 {get; set;}

	public virtual string Prop9c66a788313948e5ac70138fcf527d44 {get; set;}

	public virtual bool Prop7bfe1f2cbc954677950df7356b55bfcf {get; set;}

public static Class84c63fd599ee4cb297c068aa63072517 CreateWithRandomData()
{
	var x = new Class84c63fd599ee4cb297c068aa63072517();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop9e0d5d9c07424a5bacb2bed65b46097b = RndData.GetString();
	x.Prop4bd679a5269740cc8d0d36b173e74099 = RndData.GetInt();
	x.Prope09286e6f9f44807a71197412d87659f = RndData.GetString();
	x.Prop8e5600ae97c344f6ab555821c769eeb5 = RndData.GetInt();
	x.Propfbaee59bc785406ca964f98d1fca576a = RndData.GetBool();
	x.Propcd81af0ed2804421bef6392226f4d3e6 = RndData.GetInt();
	x.Prop1f0a433ce7ac4d8cbc910e913b751f3b = RndData.GetBool();
	x.Prop03f2fa5b664e4d04a6db59a84125aa01 = RndData.GetInt();
	x.Propdade7ffff7ac460682e8d217cfb6aedf = RndData.GetInt();
	x.Prop29bab4dc340942688c1b54f683848aed = RndData.GetString();
	x.Propdec87f4ab5964196bc9cc9f6e2b30f3f = RndData.GetBool();
	x.Propd524d4952ddd4b08be4aaba32a4748d6 = RndData.GetString();
	x.Prop9c66a788313948e5ac70138fcf527d44 = RndData.GetString();
	x.Prop7bfe1f2cbc954677950df7356b55bfcf = RndData.GetBool();
return x;
}
}

public class Class89177451ab1d47c58931ac1289279779 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop908ee5bfad7a432088f0b043840772d1 {get; set;}

	public virtual bool Propb97b615fde6845cfb205370a25ab020d {get; set;}

	public virtual int Prop2543f1974c6c4b5b9383d7e8e3d82d25 {get; set;}

	public virtual int Prop6ea5bf2ff6194f39bac0731ddb501c54 {get; set;}

	public virtual bool Propc57c94b562274c3eb32cf02b6ae7a9bb {get; set;}

	public virtual bool Prop184097c4eb9b42f5a10f12d557756bf8 {get; set;}

	public virtual int Propa7004c07efbf46c5ba1b794c8baac181 {get; set;}

	public virtual string Prop788fda0ee3904c888ec5d1690e90265f {get; set;}

	public virtual int Prop8ed5eeffb5594977b792f74c17a8bf6d {get; set;}

	public virtual bool Prop138588acbd3044fa9837ac2ab3ba0ba2 {get; set;}

	public virtual string Prop6ee7d5f19d8d43d8a376ffd2f27e6a7c {get; set;}

public static Class89177451ab1d47c58931ac1289279779 CreateWithRandomData()
{
	var x = new Class89177451ab1d47c58931ac1289279779();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop908ee5bfad7a432088f0b043840772d1 = RndData.GetBool();
	x.Propb97b615fde6845cfb205370a25ab020d = RndData.GetBool();
	x.Prop2543f1974c6c4b5b9383d7e8e3d82d25 = RndData.GetInt();
	x.Prop6ea5bf2ff6194f39bac0731ddb501c54 = RndData.GetInt();
	x.Propc57c94b562274c3eb32cf02b6ae7a9bb = RndData.GetBool();
	x.Prop184097c4eb9b42f5a10f12d557756bf8 = RndData.GetBool();
	x.Propa7004c07efbf46c5ba1b794c8baac181 = RndData.GetInt();
	x.Prop788fda0ee3904c888ec5d1690e90265f = RndData.GetString();
	x.Prop8ed5eeffb5594977b792f74c17a8bf6d = RndData.GetInt();
	x.Prop138588acbd3044fa9837ac2ab3ba0ba2 = RndData.GetBool();
	x.Prop6ee7d5f19d8d43d8a376ffd2f27e6a7c = RndData.GetString();
return x;
}
}

public class Class28efa4143cd34244b347f84c460c6b93 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop7d9c8f3f66fb476db1d405eb0595c708 {get; set;}

	public virtual string Propcf3891b83ce94fa98d30131ff68675fb {get; set;}

	public virtual Class12a840a06f454feaa897f909fb9419e6 Prop2a12b88a45fc423294c16168280f88d9 {get; set;}

	public virtual string Prop5077e597af6b4bbbb3d996ee0deeda9f {get; set;}

	public virtual int Propb3b584ffbef3424eba3a0f30002f19b4 {get; set;}

	public virtual string Prop602f6a2f454942efae8cb1b38a0895b9 {get; set;}

	public virtual int Prop3dc16f14d724419bb83a3bf72bc18340 {get; set;}

	public virtual Classebf728edcd074f18bd034800e4be715d Propdaff45cd45cd4ccd95348ea2e1e7cb13 {get; set;}

	public virtual string Prop80ca319df07445c8bec7d6eeb3c85ba4 {get; set;}

	public virtual bool Propd9e78867fa084104bda7bd950c2b5514 {get; set;}

	public virtual string Prop6cf9bf993747402fb30a227d51c4cb27 {get; set;}

	public virtual string Prop0bee1816b46e4c6cb534ef740d1856fc {get; set;}

	public virtual Classc4427648eccd4fdf98b0bf79511549b4 Prop953884ad5b8d4359ab49e23079adaea3 {get; set;}

	public virtual int Prop31e29fc68c0249f8b8c4f1250f3d08e7 {get; set;}

	public virtual bool Propa228d859863a4180a308d8c4ca2d23b9 {get; set;}

	public virtual bool Prop8fb1908dc746441aa3ded4c89acc8c30 {get; set;}

	public virtual bool Prop1ed34f4e059345bdb3c4211ac9b7f397 {get; set;}

	public virtual int Propc23638cf15e64acf880bc1aa8cb7a807 {get; set;}

	public virtual bool Propf398a3bdb7874737985c51058564161b {get; set;}

	public virtual string Prop1c57393cafac46bb945cc12893d7adc7 {get; set;}

	public virtual string Prop9f56ebef566749f4a22812260652185e {get; set;}

	public virtual string Propf53dab9e7c7d4fe79c554a3fbbfa7ed8 {get; set;}

public static Class28efa4143cd34244b347f84c460c6b93 CreateWithRandomData()
{
	var x = new Class28efa4143cd34244b347f84c460c6b93();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop7d9c8f3f66fb476db1d405eb0595c708 = RndData.GetInt();
	x.Propcf3891b83ce94fa98d30131ff68675fb = RndData.GetString();
	x.Prop2a12b88a45fc423294c16168280f88d9 = Class12a840a06f454feaa897f909fb9419e6.CreateWithRandomData();
	x.Prop5077e597af6b4bbbb3d996ee0deeda9f = RndData.GetString();
	x.Propb3b584ffbef3424eba3a0f30002f19b4 = RndData.GetInt();
	x.Prop602f6a2f454942efae8cb1b38a0895b9 = RndData.GetString();
	x.Prop3dc16f14d724419bb83a3bf72bc18340 = RndData.GetInt();
	x.Propdaff45cd45cd4ccd95348ea2e1e7cb13 = Classebf728edcd074f18bd034800e4be715d.CreateWithRandomData();
	x.Prop80ca319df07445c8bec7d6eeb3c85ba4 = RndData.GetString();
	x.Propd9e78867fa084104bda7bd950c2b5514 = RndData.GetBool();
	x.Prop6cf9bf993747402fb30a227d51c4cb27 = RndData.GetString();
	x.Prop0bee1816b46e4c6cb534ef740d1856fc = RndData.GetString();
	x.Prop953884ad5b8d4359ab49e23079adaea3 = Classc4427648eccd4fdf98b0bf79511549b4.CreateWithRandomData();
	x.Prop31e29fc68c0249f8b8c4f1250f3d08e7 = RndData.GetInt();
	x.Propa228d859863a4180a308d8c4ca2d23b9 = RndData.GetBool();
	x.Prop8fb1908dc746441aa3ded4c89acc8c30 = RndData.GetBool();
	x.Prop1ed34f4e059345bdb3c4211ac9b7f397 = RndData.GetBool();
	x.Propc23638cf15e64acf880bc1aa8cb7a807 = RndData.GetInt();
	x.Propf398a3bdb7874737985c51058564161b = RndData.GetBool();
	x.Prop1c57393cafac46bb945cc12893d7adc7 = RndData.GetString();
	x.Prop9f56ebef566749f4a22812260652185e = RndData.GetString();
	x.Propf53dab9e7c7d4fe79c554a3fbbfa7ed8 = RndData.GetString();
return x;
}
}

public class Class12a840a06f454feaa897f909fb9419e6 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop44820a0c986c4e2a885934bf4ef84216 {get; set;}

	public virtual bool Prop0f3c2d190bc74b3c92dcaaee8c23f6d2 {get; set;}

	public virtual int Propedfe8199deac479f84cd3d7a0e0aea47 {get; set;}

	public virtual bool Prop29bef0cde90245e3a9cf939a50af03a5 {get; set;}

	public virtual string Prop46a525b386bd4966b03d5a4610e4911a {get; set;}

	public virtual int Propb199db06e05e4ec08e766685b3786bf1 {get; set;}

	public virtual int Propa7a05ae834a04877ad930c25f0b0de81 {get; set;}

	public virtual bool Prop34adc759272d4bd3af863731014f4517 {get; set;}

	public virtual bool Prop5a042637174945ebb32d1ec5b6af0321 {get; set;}

	public virtual string Propfbcb51b6f9ee4b92aa4636aa80ab8acc {get; set;}

	public virtual int Prop4008caec34b645d1a1c39bcbc0fd82e8 {get; set;}

public static Class12a840a06f454feaa897f909fb9419e6 CreateWithRandomData()
{
	var x = new Class12a840a06f454feaa897f909fb9419e6();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop44820a0c986c4e2a885934bf4ef84216 = RndData.GetString();
	x.Prop0f3c2d190bc74b3c92dcaaee8c23f6d2 = RndData.GetBool();
	x.Propedfe8199deac479f84cd3d7a0e0aea47 = RndData.GetInt();
	x.Prop29bef0cde90245e3a9cf939a50af03a5 = RndData.GetBool();
	x.Prop46a525b386bd4966b03d5a4610e4911a = RndData.GetString();
	x.Propb199db06e05e4ec08e766685b3786bf1 = RndData.GetInt();
	x.Propa7a05ae834a04877ad930c25f0b0de81 = RndData.GetInt();
	x.Prop34adc759272d4bd3af863731014f4517 = RndData.GetBool();
	x.Prop5a042637174945ebb32d1ec5b6af0321 = RndData.GetBool();
	x.Propfbcb51b6f9ee4b92aa4636aa80ab8acc = RndData.GetString();
	x.Prop4008caec34b645d1a1c39bcbc0fd82e8 = RndData.GetInt();
return x;
}
}

public class Classebf728edcd074f18bd034800e4be715d : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop59b0c5f69c0f4e1b800e4c8c23c0576e {get; set;}

	public virtual int Propc3f2842cd6f64f8ab0c327552446ead5 {get; set;}

	public virtual bool Prop1d9166da97794dafab4bcd66d1ea536b {get; set;}

	public virtual Classfa700d677ab6413bbee7680ac9423ff6 Prop79f7b579229a4da989e93cb2ea0391fd {get; set;}

	public virtual bool Prop0d454b6d1ecf454080646865abc94b5b {get; set;}

	public virtual bool Prope423d1c1462942e8bd34246674124a60 {get; set;}

	public virtual Class71dc783d195842b18c3c9099e492771e Propf79a71e4277e4215930d6ed73659d63f {get; set;}

	public virtual int Prop3b1f5f506d1342b6ad7549f88ec558c1 {get; set;}

	public virtual int Propa9b5c4c375254c98a04bc2a78d29112d {get; set;}

	public virtual int Prop8ae733e6a74149ff87146283979edf1a {get; set;}

	public virtual string Prop6ab4d0287fd74443b61ad884cc3884a2 {get; set;}

	public virtual string Propee664b0dfc1449d9a404493ad73d66a8 {get; set;}

	public virtual int Propd406b7cbeeb64de28f4548be2ffe54b3 {get; set;}

	public virtual bool Prop147f616f8f5d4124a218ccde5febbede {get; set;}

	public virtual bool Prop4ec65dcb56274cd4bd00dcb3c8a38bec {get; set;}

	public virtual bool Propf192c4329fa24c4ca86dc65769d581df {get; set;}

	public virtual int Prop5766afcd623e44a495ee9e0469a9d93f {get; set;}

	public virtual int Propd4aedd46df564b19a658c20d1a5cae5b {get; set;}

	public virtual bool Prope018af38477c48ae964c575b8a69b035 {get; set;}

	public virtual string Propdacdda2c450a4d4b823e4d4d6fc30096 {get; set;}

	public virtual bool Prop3a02f198f5224db987bbf89c83347ed9 {get; set;}

	public virtual bool Propf6019087bd4f45f29771d4eb4af3ab47 {get; set;}

	public virtual int Propcf13420573b14f80b61a869a7171e32d {get; set;}

public static Classebf728edcd074f18bd034800e4be715d CreateWithRandomData()
{
	var x = new Classebf728edcd074f18bd034800e4be715d();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop59b0c5f69c0f4e1b800e4c8c23c0576e = RndData.GetBool();
	x.Propc3f2842cd6f64f8ab0c327552446ead5 = RndData.GetInt();
	x.Prop1d9166da97794dafab4bcd66d1ea536b = RndData.GetBool();
	x.Prop79f7b579229a4da989e93cb2ea0391fd = Classfa700d677ab6413bbee7680ac9423ff6.CreateWithRandomData();
	x.Prop0d454b6d1ecf454080646865abc94b5b = RndData.GetBool();
	x.Prope423d1c1462942e8bd34246674124a60 = RndData.GetBool();
	x.Propf79a71e4277e4215930d6ed73659d63f = Class71dc783d195842b18c3c9099e492771e.CreateWithRandomData();
	x.Prop3b1f5f506d1342b6ad7549f88ec558c1 = RndData.GetInt();
	x.Propa9b5c4c375254c98a04bc2a78d29112d = RndData.GetInt();
	x.Prop8ae733e6a74149ff87146283979edf1a = RndData.GetInt();
	x.Prop6ab4d0287fd74443b61ad884cc3884a2 = RndData.GetString();
	x.Propee664b0dfc1449d9a404493ad73d66a8 = RndData.GetString();
	x.Propd406b7cbeeb64de28f4548be2ffe54b3 = RndData.GetInt();
	x.Prop147f616f8f5d4124a218ccde5febbede = RndData.GetBool();
	x.Prop4ec65dcb56274cd4bd00dcb3c8a38bec = RndData.GetBool();
	x.Propf192c4329fa24c4ca86dc65769d581df = RndData.GetBool();
	x.Prop5766afcd623e44a495ee9e0469a9d93f = RndData.GetInt();
	x.Propd4aedd46df564b19a658c20d1a5cae5b = RndData.GetInt();
	x.Prope018af38477c48ae964c575b8a69b035 = RndData.GetBool();
	x.Propdacdda2c450a4d4b823e4d4d6fc30096 = RndData.GetString();
	x.Prop3a02f198f5224db987bbf89c83347ed9 = RndData.GetBool();
	x.Propf6019087bd4f45f29771d4eb4af3ab47 = RndData.GetBool();
	x.Propcf13420573b14f80b61a869a7171e32d = RndData.GetInt();
return x;
}
}

public class Classfa700d677ab6413bbee7680ac9423ff6 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop90be281f741d4fcc88f4b234cd9cc897 {get; set;}

	public virtual bool Prop8978dca3a7d64561b0a51f6f039dae55 {get; set;}

	public virtual string Prop1044fd9f56704a6d95df50eafd9b2a50 {get; set;}

	public virtual string Propa172d404b2c44b0eb18ee91eacd1a4f1 {get; set;}

	public virtual int Propaa6d8b76045245d3af04d96b61841f7a {get; set;}

	public virtual string Prop57ad4fcd65d44062bc3b22217c84c181 {get; set;}

	public virtual int Prop70ffe38dc936452f9f58d8497de9fbd9 {get; set;}

	public virtual string Propb23c531b9fb64a08b476010d76978031 {get; set;}

	public virtual bool Prop07d8718e9a8c4ebf94964dfcf95b1800 {get; set;}

	public virtual bool Prop87dca5369a304a679665759edb32825a {get; set;}

public static Classfa700d677ab6413bbee7680ac9423ff6 CreateWithRandomData()
{
	var x = new Classfa700d677ab6413bbee7680ac9423ff6();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop90be281f741d4fcc88f4b234cd9cc897 = RndData.GetString();
	x.Prop8978dca3a7d64561b0a51f6f039dae55 = RndData.GetBool();
	x.Prop1044fd9f56704a6d95df50eafd9b2a50 = RndData.GetString();
	x.Propa172d404b2c44b0eb18ee91eacd1a4f1 = RndData.GetString();
	x.Propaa6d8b76045245d3af04d96b61841f7a = RndData.GetInt();
	x.Prop57ad4fcd65d44062bc3b22217c84c181 = RndData.GetString();
	x.Prop70ffe38dc936452f9f58d8497de9fbd9 = RndData.GetInt();
	x.Propb23c531b9fb64a08b476010d76978031 = RndData.GetString();
	x.Prop07d8718e9a8c4ebf94964dfcf95b1800 = RndData.GetBool();
	x.Prop87dca5369a304a679665759edb32825a = RndData.GetBool();
return x;
}
}

public class Class71dc783d195842b18c3c9099e492771e : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop1c9ec065164d4bf0988f3abcd9d6ce10 {get; set;}

	public virtual int Prop0304aafdda164879b45d12fd100a49a1 {get; set;}

	public virtual bool Prop1ae8c70785604ee59b2dc66d5ba11eaa {get; set;}

	public virtual bool Prop17fcb701bf054ff49f45a7f607c89395 {get; set;}

	public virtual string Propbebe67b5f2314389b025c020fb74c3d6 {get; set;}

	public virtual string Prop4c46c8f0ce7f4f8fbb8b0fce79ff157b {get; set;}

	public virtual int Prope4cf24740cc745f7a5947d10ffc256b4 {get; set;}

	public virtual bool Propeabcc11527d945f4aca6a080d9aa742c {get; set;}

	public virtual int Prop9576eb11a0334490908bc3b8156eee81 {get; set;}

	public virtual string Propa58411f40e2341cb93a9db1afbb27646 {get; set;}

	public virtual int Prop9ada59f0957a45ed9cc191ab53f40cda {get; set;}

	public virtual string Propadb9ed207213408eb67943fe95e5f240 {get; set;}

	public virtual bool Propb84db85fd6cb4a67a55c0c85e05bc692 {get; set;}

public static Class71dc783d195842b18c3c9099e492771e CreateWithRandomData()
{
	var x = new Class71dc783d195842b18c3c9099e492771e();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop1c9ec065164d4bf0988f3abcd9d6ce10 = RndData.GetString();
	x.Prop0304aafdda164879b45d12fd100a49a1 = RndData.GetInt();
	x.Prop1ae8c70785604ee59b2dc66d5ba11eaa = RndData.GetBool();
	x.Prop17fcb701bf054ff49f45a7f607c89395 = RndData.GetBool();
	x.Propbebe67b5f2314389b025c020fb74c3d6 = RndData.GetString();
	x.Prop4c46c8f0ce7f4f8fbb8b0fce79ff157b = RndData.GetString();
	x.Prope4cf24740cc745f7a5947d10ffc256b4 = RndData.GetInt();
	x.Propeabcc11527d945f4aca6a080d9aa742c = RndData.GetBool();
	x.Prop9576eb11a0334490908bc3b8156eee81 = RndData.GetInt();
	x.Propa58411f40e2341cb93a9db1afbb27646 = RndData.GetString();
	x.Prop9ada59f0957a45ed9cc191ab53f40cda = RndData.GetInt();
	x.Propadb9ed207213408eb67943fe95e5f240 = RndData.GetString();
	x.Propb84db85fd6cb4a67a55c0c85e05bc692 = RndData.GetBool();
return x;
}
}

public class Classc4427648eccd4fdf98b0bf79511549b4 : IEntity
{
	public virtual string Id {get; set;}

	public virtual string Prop6af568bf4e754c2aa9316b480975b88d {get; set;}

	public virtual int Prop94d362790c52415aa28a465add9850e0 {get; set;}

	public virtual string Propb053a6f1860c4d1ab41f1b03e1c4ca96 {get; set;}

	public virtual ICollection<Class00b89d4293054b9abd1e9d9b80d4b64b> Prop5b24d77ce55b4bd794e961091417f92e {get; set;}

	public virtual Classa47c6ce894da4af2bedaf1fac19b15e6 Prop22e9905024374e19b42d547c6a9a7671 {get; set;}

	public virtual int Prop22b71aba2a274eba85efa1ea4a4ed7ad {get; set;}

	public virtual int Prop52c2e298af9349da9e5582998e7858fa {get; set;}

	public virtual int Prop72d1431cbf054cafa246c1f8aba66b57 {get; set;}

	public virtual int Prop859710d979b749cdbce27eda8e590cea {get; set;}

	public virtual string Prop0ce8bd739f3e48a39d13eb310f0df5b8 {get; set;}

	public virtual bool Prop23497410f92646a381e3ca052d7e8b86 {get; set;}

public static Classc4427648eccd4fdf98b0bf79511549b4 CreateWithRandomData()
{
	var x = new Classc4427648eccd4fdf98b0bf79511549b4();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop6af568bf4e754c2aa9316b480975b88d = RndData.GetString();
	x.Prop94d362790c52415aa28a465add9850e0 = RndData.GetInt();
	x.Propb053a6f1860c4d1ab41f1b03e1c4ca96 = RndData.GetString();
	x.Prop5b24d77ce55b4bd794e961091417f92e = new List<Class00b89d4293054b9abd1e9d9b80d4b64b>(RndData.GetList(10, Class00b89d4293054b9abd1e9d9b80d4b64b.CreateWithRandomData));
	x.Prop22e9905024374e19b42d547c6a9a7671 = Classa47c6ce894da4af2bedaf1fac19b15e6.CreateWithRandomData();
	x.Prop22b71aba2a274eba85efa1ea4a4ed7ad = RndData.GetInt();
	x.Prop52c2e298af9349da9e5582998e7858fa = RndData.GetInt();
	x.Prop72d1431cbf054cafa246c1f8aba66b57 = RndData.GetInt();
	x.Prop859710d979b749cdbce27eda8e590cea = RndData.GetInt();
	x.Prop0ce8bd739f3e48a39d13eb310f0df5b8 = RndData.GetString();
	x.Prop23497410f92646a381e3ca052d7e8b86 = RndData.GetBool();
return x;
}
}

public class Class00b89d4293054b9abd1e9d9b80d4b64b : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Propab179fd219db45daac75dd7d4c0351c7 {get; set;}

	public virtual bool Prop5b0b52f62b8f4928a2e4a2358b1e4a9a {get; set;}

	public virtual int Propbce6b129cc374af49ae79d447ff00e20 {get; set;}

	public virtual string Prop6660b8edc7e748a880691cd29cdbb28e {get; set;}

	public virtual bool Prop06d92ef17b174bbe9a57de9390156140 {get; set;}

	public virtual int Propc05e4fc379cc4f01b4f79836cdec86ba {get; set;}

	public virtual bool Propafb7089999244234a356c7c201ef89c3 {get; set;}

	public virtual int Prop0363b0a79d1f4a21a7e02aacab5ad54e {get; set;}

	public virtual string Prop78a1e37662154dbca498c47197306a40 {get; set;}

	public virtual int Propc2b98d1b72db4a4db663d7299baa445c {get; set;}

	public virtual string Propfd735bb509314081b47aef9a4cebbb91 {get; set;}

	public virtual bool Prop242ce56fd8ad402d8b6e42129c39e7b2 {get; set;}

	public virtual bool Prop6d8781348e4e4537a68c1f35e8a8a7e7 {get; set;}

	public virtual bool Prop7b56aab2428f4cdca4333eb52ee05bca {get; set;}

	public virtual bool Propa01614d1de184c3d8e88b24d21af3f4f {get; set;}

	public virtual int Propd12aee8f462247ef9eb9f20f08736c5b {get; set;}

	public virtual bool Prop89bc1ae674374a758d383379eb208d40 {get; set;}

public static Class00b89d4293054b9abd1e9d9b80d4b64b CreateWithRandomData()
{
	var x = new Class00b89d4293054b9abd1e9d9b80d4b64b();
	x.Id = Guid.NewGuid().ToString("N");
	x.Propab179fd219db45daac75dd7d4c0351c7 = RndData.GetInt();
	x.Prop5b0b52f62b8f4928a2e4a2358b1e4a9a = RndData.GetBool();
	x.Propbce6b129cc374af49ae79d447ff00e20 = RndData.GetInt();
	x.Prop6660b8edc7e748a880691cd29cdbb28e = RndData.GetString();
	x.Prop06d92ef17b174bbe9a57de9390156140 = RndData.GetBool();
	x.Propc05e4fc379cc4f01b4f79836cdec86ba = RndData.GetInt();
	x.Propafb7089999244234a356c7c201ef89c3 = RndData.GetBool();
	x.Prop0363b0a79d1f4a21a7e02aacab5ad54e = RndData.GetInt();
	x.Prop78a1e37662154dbca498c47197306a40 = RndData.GetString();
	x.Propc2b98d1b72db4a4db663d7299baa445c = RndData.GetInt();
	x.Propfd735bb509314081b47aef9a4cebbb91 = RndData.GetString();
	x.Prop242ce56fd8ad402d8b6e42129c39e7b2 = RndData.GetBool();
	x.Prop6d8781348e4e4537a68c1f35e8a8a7e7 = RndData.GetBool();
	x.Prop7b56aab2428f4cdca4333eb52ee05bca = RndData.GetBool();
	x.Propa01614d1de184c3d8e88b24d21af3f4f = RndData.GetBool();
	x.Propd12aee8f462247ef9eb9f20f08736c5b = RndData.GetInt();
	x.Prop89bc1ae674374a758d383379eb208d40 = RndData.GetBool();
return x;
}
}

public class Classa47c6ce894da4af2bedaf1fac19b15e6 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop539fef6779134b8d9502aee615cf373e {get; set;}

	public virtual int Propf02cbc5f205f4000a4e38552ccc81570 {get; set;}

	public virtual bool Propad7e82a88ac745b5b7d3668d7030b27e {get; set;}

	public virtual bool Prop9abb34d7d06e42d6856283d21ebd6986 {get; set;}

	public virtual int Prope57c3e0f917a462d8eb67350d0c8412d {get; set;}

	public virtual int Prop4e50a489c0fd41c9a218f92ef1f95619 {get; set;}

	public virtual string Prop7b3cbb634edf4b48a695e50f4394baaa {get; set;}

	public virtual string Propf22fd7bcc1a94e8fb12de3f6b07e06f2 {get; set;}

	public virtual string Prop4ee2b5460bd14d8cbb285f5ced00c371 {get; set;}

	public virtual string Prop8b9b564516ad4ce981db60901af6d0c3 {get; set;}

	public virtual int Propcf01e662d9704ef1ad40b4edc9739482 {get; set;}

	public virtual bool Propcee89332e2a64402b3b19a0a7188e7b6 {get; set;}

	public virtual int Prop8c194ad8b862400fa9cb0278a2ca694e {get; set;}

	public virtual int Prop3c707ca7276f4322ac4217d5aab12729 {get; set;}

	public virtual string Prop3cee5e04c41a48cf991b650109b14c0a {get; set;}

	public virtual bool Propc9c5b097cc5e427187f04a5e5ca1b757 {get; set;}

	public virtual int Propf2efb1aadefa4ee986899cbbea84c634 {get; set;}

	public virtual int Prop921f6564c55d4a11ade1ef5eab1f7288 {get; set;}

	public virtual string Propf3cd2cf17f1a4919a787586219eabe64 {get; set;}

	public virtual string Prop5cf6de829bd549b491be8aef36b4aaba {get; set;}

	public virtual bool Prop8a3e199170f0480db1e37c1086b97036 {get; set;}

	public virtual bool Prop3e5824e4b1fc495e8fa52aa61322b772 {get; set;}

	public virtual string Propf2b2b5bd3abf4defba00ee4f0d63d02a {get; set;}

public static Classa47c6ce894da4af2bedaf1fac19b15e6 CreateWithRandomData()
{
	var x = new Classa47c6ce894da4af2bedaf1fac19b15e6();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop539fef6779134b8d9502aee615cf373e = RndData.GetInt();
	x.Propf02cbc5f205f4000a4e38552ccc81570 = RndData.GetInt();
	x.Propad7e82a88ac745b5b7d3668d7030b27e = RndData.GetBool();
	x.Prop9abb34d7d06e42d6856283d21ebd6986 = RndData.GetBool();
	x.Prope57c3e0f917a462d8eb67350d0c8412d = RndData.GetInt();
	x.Prop4e50a489c0fd41c9a218f92ef1f95619 = RndData.GetInt();
	x.Prop7b3cbb634edf4b48a695e50f4394baaa = RndData.GetString();
	x.Propf22fd7bcc1a94e8fb12de3f6b07e06f2 = RndData.GetString();
	x.Prop4ee2b5460bd14d8cbb285f5ced00c371 = RndData.GetString();
	x.Prop8b9b564516ad4ce981db60901af6d0c3 = RndData.GetString();
	x.Propcf01e662d9704ef1ad40b4edc9739482 = RndData.GetInt();
	x.Propcee89332e2a64402b3b19a0a7188e7b6 = RndData.GetBool();
	x.Prop8c194ad8b862400fa9cb0278a2ca694e = RndData.GetInt();
	x.Prop3c707ca7276f4322ac4217d5aab12729 = RndData.GetInt();
	x.Prop3cee5e04c41a48cf991b650109b14c0a = RndData.GetString();
	x.Propc9c5b097cc5e427187f04a5e5ca1b757 = RndData.GetBool();
	x.Propf2efb1aadefa4ee986899cbbea84c634 = RndData.GetInt();
	x.Prop921f6564c55d4a11ade1ef5eab1f7288 = RndData.GetInt();
	x.Propf3cd2cf17f1a4919a787586219eabe64 = RndData.GetString();
	x.Prop5cf6de829bd549b491be8aef36b4aaba = RndData.GetString();
	x.Prop8a3e199170f0480db1e37c1086b97036 = RndData.GetBool();
	x.Prop3e5824e4b1fc495e8fa52aa61322b772 = RndData.GetBool();
	x.Propf2b2b5bd3abf4defba00ee4f0d63d02a = RndData.GetString();
return x;
}
}

public class Class4400b92ae3a3422aae70d3ad1c161279 : IEntity
{
	public virtual string Id {get; set;}

	public virtual int Prop87b5b3efab804f96add4cfce155ab28f {get; set;}

	public virtual int Propfedf6c03fcb542dda472c15ac436d379 {get; set;}

	public virtual string Propf70ef9fc021443efaa7b52a14c7085e5 {get; set;}

	public virtual string Propa9dce62912ea4aee90335d2b1f4ea34c {get; set;}

	public virtual string Prop474e6e45675b49ba8df259e6dd5a36eb {get; set;}

	public virtual bool Prop79c4e44a276942ca82a8a5c755917fc1 {get; set;}

	public virtual string Prop46618e7350c54cfc8bed0acc87a6e2c3 {get; set;}

	public virtual int Propbe9ba088b8854a708c2db157ab76ed13 {get; set;}

	public virtual bool Propeada9551f7014d25b35aee8bc37dc554 {get; set;}

	public virtual string Prop3d624d0dfef24be298ce26955ea51005 {get; set;}

	public virtual bool Prop5aaa2cb33342491792a1d72526e7a959 {get; set;}

	public virtual int Prop01119eda86984cd9ba615306e55fd83c {get; set;}

	public virtual bool Prop3d688992221d429aa2f12003f8c33363 {get; set;}

	public virtual string Prop50edc51dbc3d48dcbec96f2d9a35abe2 {get; set;}

	public virtual int Propd6e72eca229144dab4a3d7fa6e9c7fb8 {get; set;}

	public virtual string Propa850c1ed2f564a6080e6c08e3cd33497 {get; set;}

public static Class4400b92ae3a3422aae70d3ad1c161279 CreateWithRandomData()
{
	var x = new Class4400b92ae3a3422aae70d3ad1c161279();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop87b5b3efab804f96add4cfce155ab28f = RndData.GetInt();
	x.Propfedf6c03fcb542dda472c15ac436d379 = RndData.GetInt();
	x.Propf70ef9fc021443efaa7b52a14c7085e5 = RndData.GetString();
	x.Propa9dce62912ea4aee90335d2b1f4ea34c = RndData.GetString();
	x.Prop474e6e45675b49ba8df259e6dd5a36eb = RndData.GetString();
	x.Prop79c4e44a276942ca82a8a5c755917fc1 = RndData.GetBool();
	x.Prop46618e7350c54cfc8bed0acc87a6e2c3 = RndData.GetString();
	x.Propbe9ba088b8854a708c2db157ab76ed13 = RndData.GetInt();
	x.Propeada9551f7014d25b35aee8bc37dc554 = RndData.GetBool();
	x.Prop3d624d0dfef24be298ce26955ea51005 = RndData.GetString();
	x.Prop5aaa2cb33342491792a1d72526e7a959 = RndData.GetBool();
	x.Prop01119eda86984cd9ba615306e55fd83c = RndData.GetInt();
	x.Prop3d688992221d429aa2f12003f8c33363 = RndData.GetBool();
	x.Prop50edc51dbc3d48dcbec96f2d9a35abe2 = RndData.GetString();
	x.Propd6e72eca229144dab4a3d7fa6e9c7fb8 = RndData.GetInt();
	x.Propa850c1ed2f564a6080e6c08e3cd33497 = RndData.GetString();
return x;
}
}

public class Class9e69c8c79443439a9aa3abac37dd6d87 : IEntity
{
	public virtual string Id {get; set;}

	public virtual bool Prop67e4a96ef48b4d32a94712cc1ff16bba {get; set;}

	public virtual bool Propd6d79abb78f141e7846843cf4dff1a2b {get; set;}

	public virtual string Propd545b369e4ac4d36b4bf3943e6170189 {get; set;}

	public virtual bool Prope91f47bea8e34463b05ae00ad73be82a {get; set;}

	public virtual string Prop7873165960b540c9958930914ada212a {get; set;}

	public virtual bool Prop57c8ba3ee7b5411bbe7dec50ff84001e {get; set;}

	public virtual string Propb4222b027d374498a74d4f34570367a5 {get; set;}

	public virtual string Propc2f5d22156134457a90ff89430f04808 {get; set;}

	public virtual string Propaac9606a890a47f9a6051c5575f3f7d1 {get; set;}

	public virtual int Prop4c0ee9d743dd43a3977d74f6ac8c1213 {get; set;}

	public virtual bool Prop50a71f5317524b07b1b428e39f258d18 {get; set;}

	public virtual int Prop7eaeb4cbeb8344fd8ed8e28f551e3a57 {get; set;}

public static Class9e69c8c79443439a9aa3abac37dd6d87 CreateWithRandomData()
{
	var x = new Class9e69c8c79443439a9aa3abac37dd6d87();
	x.Id = Guid.NewGuid().ToString("N");
	x.Prop67e4a96ef48b4d32a94712cc1ff16bba = RndData.GetBool();
	x.Propd6d79abb78f141e7846843cf4dff1a2b = RndData.GetBool();
	x.Propd545b369e4ac4d36b4bf3943e6170189 = RndData.GetString();
	x.Prope91f47bea8e34463b05ae00ad73be82a = RndData.GetBool();
	x.Prop7873165960b540c9958930914ada212a = RndData.GetString();
	x.Prop57c8ba3ee7b5411bbe7dec50ff84001e = RndData.GetBool();
	x.Propb4222b027d374498a74d4f34570367a5 = RndData.GetString();
	x.Propc2f5d22156134457a90ff89430f04808 = RndData.GetString();
	x.Propaac9606a890a47f9a6051c5575f3f7d1 = RndData.GetString();
	x.Prop4c0ee9d743dd43a3977d74f6ac8c1213 = RndData.GetInt();
	x.Prop50a71f5317524b07b1b428e39f258d18 = RndData.GetBool();
	x.Prop7eaeb4cbeb8344fd8ed8e28f551e3a57 = RndData.GetInt();
return x;
}
}
}
