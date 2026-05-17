namespace RD_AAOW
	{
	/// <summary>
	/// Класс объединяет все подклассы справочников и помощников приложения
	/// </summary>
	public class KnowledgeBase
		{
		/// <summary>
		/// Возвращает справочник ОФД
		/// </summary>
		public OFD Ofd
			{
			get
				{
				if (ofd == null)
					ofd = new OFD ();

				return ofd;
				}
			}
		private OFD ofd;

		/// <summary>
		/// Возвращает оператор заводских номеров ККТ
		/// </summary>
		public KKTSerial KKTNumbers
			{
			get
				{
				if (kkts == null)
					kkts = new KKTSerial ();

				return kkts;
				}
			}
		private KKTSerial kkts;

		/// <summary>
		/// Возвращает оператор заводских номеров ФН
		/// </summary>
		public FNSerial FNNumbers
			{
			get
				{
				if (fns == null)
					fns = new FNSerial ();

				return fns;
				}
			}
		private FNSerial fns;

#if !KASSARRAYPR && !KASSARRAYEC

		/// <summary>
		/// Возвращает преобразователь текста в коды символов ККТ
		/// </summary>
		public KKTCodes CodeTables
			{
			get
				{
				if (kktc == null)
					kktc = new KKTCodes ();

				return kktc;
				}
			}
		private KKTCodes kktc;

		/// <summary>
		/// Возвращает справочник ошибок ККТ
		/// </summary>
		public KKTErrorsList Errors
			{
			get
				{
				if (kkte == null)
					kkte = new KKTErrorsList ();

				return kkte;
				}
			}
		private KKTErrorsList kkte;

		/// <summary>
		/// Возвращает справочник команд нижнего уровня
		/// </summary>
		public TermsDictionary Dictionary
			{
			get
				{
				if (td == null)
					td = new TermsDictionary ();

				return td;
				}
			}
		private TermsDictionary td;

		/// <summary>
		/// Возвращает оператор руководств пользователя ККТ
		/// </summary>
		public UserGuides UserGuides
			{
			get
				{
				if (ug == null)
					ug = new UserGuides ();

				return ug;
				}
			}
		private UserGuides ug;

		/// <summary>
		/// Возвращает справочник TLV-тегов
		/// </summary>
		public TLVTags Tags
			{
			get
				{
				if (tlvt == null)
					tlvt = new TLVTags ();

				return tlvt;
				}
			}
		private TLVTags tlvt;

		/// <summary>
		/// Возвращает оператор штрих-кодов
		/// </summary>
		public BarCodes Barcodes
			{
			get
				{
				if (barc == null)
					barc = new BarCodes ();

				return barc;
				}
			}
		private BarCodes barc;

		/// <summary>
		/// Возвращает справочник разъёмов ККТ и торгового оборудования
		/// </summary>
		public Connectors Plugs
			{
			get
				{
				if (conn == null)
					conn = new Connectors ();

				return conn;
				}
			}
		private Connectors conn;

		/// <summary>
		/// Возвращает справочник описаний символов Unicode
		/// </summary>
		public UnicodeDescriptor Unicodes
			{
			get
				{
				if (ud == null)
					ud = new UnicodeDescriptor ();

				return ud;
				}
			}
		private UnicodeDescriptor ud;

		/// <summary>
		/// Возвращает справочник команд нижнего уровня
		/// </summary>
		public LowLevel LLCommands
			{
			get
				{
				if (ll == null)
					ll = new LowLevel ();

				return ll;
				}
			}
		private LowLevel ll;

#endif

		/// <summary>
		/// Конструктор-заглушка
		/// </summary>
		public KnowledgeBase ()
			{
			/*ofd = new OFD ();
			kkts = new KKTSerial ();
			fns = new FNSerial ();

if !KASSARRAYPR && !KASSARRAYEC

			kktc = new KKTCodes ();
			kkte = new KKTErrorsList ();
			td = new TermsDictionary ();
			ug = new UserGuides ();
			tlvt = new TLVTags ();
			barc = new BarCodes ();
			conn = new Connectors ();
			ud = new UnicodeDescriptor ();
			ll = new LowLevel ();

endif*/
			}
		}
	}
