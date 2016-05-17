using System;
using Java.IO;
using NUnit.Framework;
using iTextSharp.IO.Font;
using iTextSharp.Kernel.Color;
using iTextSharp.Kernel.Font;
using iTextSharp.Kernel.Pdf;
using iTextSharp.Kernel.Pdf.Canvas;
using iTextSharp.Kernel.Utils;
using iTextSharp.Layout.Element;
using iTextSharp.Test;

namespace iTextSharp.Layout
{
	public class TextWritingTest : ExtendedITextTest
	{
		public const String sourceFolder = "../../resources/itextsharp/layout/TextWritingTest/";

		public const String destinationFolder = "test/itextsharp/layout/TextWritingTest/";

		[TestFixtureSetUp]
		public static void BeforeClass()
		{
			CreateDestinationFolder(destinationFolder);
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void TextRiseTest01()
		{
			// CountryChunks example
			String outFileName = destinationFolder + "textRiseTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_textRiseTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);
			for (int i = 0; i < 10; i++)
			{
				Paragraph p = new Paragraph().Add("country").Add(" ");
				Text id = new Text("id").SetTextRise(6).SetFont(font).SetFontSize(6).SetFontColor
					(iTextSharp.Kernel.Color.Color.WHITE).SetBackgroundColor(iTextSharp.Kernel.Color.Color
					.BLACK, 0, 0, 0, 0);
				p.Add(id);
				document.Add(p);
			}
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void TextRenderingModeTest01()
		{
			String outFileName = destinationFolder + "textRenderingModeTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_textRenderingModeTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			Text text1 = new Text("This is a fill and stroke text").SetTextRenderingMode(PdfCanvasConstants.TextRenderingMode
				.FILL_STROKE).SetStrokeColor(iTextSharp.Kernel.Color.Color.RED).SetStrokeWidth(0.1f
				);
			document.Add(new Paragraph().Add(text1));
			Text text2 = new Text("This is a stroke-only text").SetTextRenderingMode(PdfCanvasConstants.TextRenderingMode
				.STROKE).SetStrokeColor(iTextSharp.Kernel.Color.Color.GREEN).SetStrokeWidth(0.3f
				);
			document.Add(new Paragraph(text2));
			Text text3 = new Text("This is a colorful text").SetTextRenderingMode(PdfCanvasConstants.TextRenderingMode
				.FILL_STROKE).SetStrokeColor(iTextSharp.Kernel.Color.Color.BLUE).SetStrokeWidth(
				0.3f).SetFontColor(iTextSharp.Kernel.Color.Color.GREEN).SetFontSize(20);
			document.Add(new Paragraph(text3));
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void LeadingTest01()
		{
			String outFileName = destinationFolder + "leadingTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_leadingTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			Paragraph p1 = new Paragraph("first, leading of 150").SetFixedLeading(150);
			document.Add(p1);
			Paragraph p2 = new Paragraph("second, leading of 500").SetFixedLeading(500);
			document.Add(p2);
			Paragraph p3 = new Paragraph();
			p3.Add(new Text("third, leading of 20")).SetFixedLeading(20);
			document.Add(p3);
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void FirstLineIndentTest01()
		{
			String outFileName = destinationFolder + "firstLineIndentTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_firstLineIndentTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			document.SetProperty(iTextSharp.Layout.Property.Property.FIRST_LINE_INDENT, 25);
			document.Add(new Paragraph("Portable Document Format (PDF) is a file format used to present documents in a manner "
				 + "independent of application software, hardware, and operating systems.[2] Each PDF file encapsulates a complete "
				 + "description of a fixed-layout flat document, including the text, fonts, graphics, and other information needed to "
				 + "display it. In 1991, Adobe Systems co-founder John Warnock outlined a system called \"Camelot\"[3] that evolved into PDF."
				));
			document.Add(new Paragraph("While Adobe Systems made the PDF specification available free of charge in 1993, PDF was a proprietary format, controlled "
				 + "by Adobe, until it was officially released as an open standard on July 1, 2008, and published by the International Organization for"
				 + " Standardization as ISO 32000-1:2008,[4][5] at which time control of the specification passed to an ISO Committee of volunteer industry "
				 + "experts. In 2008, Adobe published a Public Patent License to ISO 32000-1 granting royalty-free rights for all patents owned by Adobe that "
				 + "are necessary to make, use, sell and distribute PDF compliant implementations.[6] However, there are still some proprietary technologies"
				 + " with published specification defined only by Adobe, such as Adobe XML Forms Architecture, and JavaScript for Acrobat, which are referenced "
				 + "by ISO 32000-1 as normative and indispensable for the application of ISO 32000-1 specification.[7][8][9][10][11] The ISO committee is actively"
				 + " standardizing many of these as part of ISO 32000-2.").SetFirstLineIndent(50
				));
			document.Add(new AreaBreak());
			document.Add(new Paragraph("During Harry's fourth year of school (detailed in Harry Potter and the Goblet of Fire), Harry is unwillingly entered as a participant in the Triwizard Tournament, a dangerous contest where Harry must compete against a witch and a wizard \"champion\" from visiting schools as well as another Hogwarts student, causing Harry's friends to distance themselves from him.[18] Harry is guided through the tournament by their new Defence Against the Dark Arts professor, Alastor \"Mad-Eye\" Moody, who turns out to be an impostor\u2014one of Voldemort's supporters named Barty Crouch, Jr. in disguise. The point at which the mystery is unravelled marks the series' shift from foreboding and uncertainty into open conflict. Voldemort's plan to have Crouch use the tournament to bring Harry to Voldemort succeeds. Although Harry manages to escape, Cedric Diggory, the other Hogwarts champion in the tournament, is killed by Peter Pettigrew and Voldemort re-enters the wizarding world with a physical body.\n"
				 + "\n" + "In the fifth book, Harry Potter and the Order of the Phoenix, Harry must confront the newly resurfaced Voldemort. In response to Voldemort's reappearance, Dumbledore re-activates the Order of the Phoenix, a secret society which works from Sirius Black's dark family home to defeat Voldemort's minions and protect Voldemort's targets, especially Harry. Despite Harry's description of Voldemort's recent activities, the Ministry of Magic and many others in the magical world refuse to believe that Voldemort has returned.[19] In an attempt to counter and eventually discredit Dumbledore, who along with Harry is the most prominent voice in the wizarding world attempting to warn of Voldemort's return, the Ministry appoints Dolores Umbridge as the High Inquisitor of Hogwarts and the new Defence Against the Dark Arts teacher. She transforms the school into a dictatorial regime and refuses to allow the students to learn ways to defend themselves against dark magic.[19]\n"
				 + "\n" + "With Ron and Hermione's suggestion, Harry reluctantly forms \"Dumbledore's Army,\" a secret study group aimed to teach his classmates the higher-level skills of Defence Against the Dark Arts that he has learned from his previous encounters with Dark wizards. An important prophecy concerning Harry and Lord Voldemort is revealed,[20] and Harry discovers that he and Voldemort have a painful connection, allowing Harry to view some of Voldemort's actions telepathically. In the novel's climax, Harry and his friends face off against Voldemort's Death Eaters at the Ministry of Magic. Although the timely arrival of members of the Order of the Phoenix saves the children's lives, Sirius Black is killed in the conflict.\n"
				 + "\n" + "In the sixth book, Harry Potter and the Half-Blood Prince, Voldemort begins waging open warfare. Harry and his friends are relatively protected from that danger at Hogwarts. They are subject to all the difficulties of adolescence\u2014Harry eventually begins dating Ginny, Ron establishes a strong infatuation with fellow Hogwarts student Lavender Brown, and Hermione starts recognising her loving feelings for Ron. Near the beginning of the novel, lacking his own book, Harry is given an old potions textbook filled with many annotations and recommendations signed by a mysterious writer; \"the Half-Blood Prince.\" This book is a source of scholastic success and great recognition from their new potions master, Horace Slughorn, but because of the potency of the spells that are written in it, becomes a source of concern. Harry takes private lessons with Dumbledore, who shows him various memories concerning the early life of Voldemort in a device called a Pensieve. These reveal that in order to preserve his life, Voldemort has split his soul into pieces, creating a series of horcruxes - evil enchanted items hidden in various locations, one of which was the diary destroyed in the second book.[21] Harry's snobbish adversary, Draco Malfoy, attempts to attack Dumbledore, and the book culminates in the killing of Dumbledore by Professor Snape, the titular Half-Blood Prince.\n"
				 + "\n" + "Harry Potter and the Deathly Hallows, the last book in the series, begins directly after the events of the sixth book. Lord Voldemort has completed his ascension to power and gains control of the Ministry of Magic. Harry, Ron and Hermione drop out of school so that they can find and destroy Voldemort's remaining horcruxes. To ensure their own safety as well as that of their family and friends, they are forced to isolate themselves. As they search for the horcruxes, the trio learns details about Dumbledore's past, as well as Snape's true motives\u2014he had worked on Dumbledore's behalf since the murder of Harry's mother.\n"
				 + "\n" + "The book culminates in the Battle of Hogwarts. Harry, Ron and Hermione, in conjunction with members of the Order of the Phoenix and many of the teachers and students, defend Hogwarts from Voldemort, his Death Eaters, and various dangerous magical creatures. Several major characters are killed in the first wave of the battle, including Remus Lupin and Fred Weasley. After learning that he himself is a horcrux, Harry surrenders himself to Voldemort in the Forbidden Forest, who casts a killing curse (Avada Kedavra) at him. The defenders of Hogwarts do not surrender after learning of Harry's presumed death and continue to fight on. Harry awakens and faces Voldemort, whose horcruxes have all been destroyed. In the final battle, Voldemort's killing curse rebounds off Harry's defensive spell (Expelliarmus) killing Voldemort.\n"
				 + "\n" + "An epilogue describes the lives of the surviving characters and the effects of Voldemort's death on the wizarding world."
				));
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void CharSpacingTest01()
		{
			String outFileName = destinationFolder + "charSpacingTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_charSpacingTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA);
			Paragraph p = new Paragraph().SetFont(font);
			p.Add("Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document.\n"
				 + "To make your document look professionally produced, Word provides header, footer, cover page, and text box designs that complement each other. For example, you can add a matching cover page, header, and sidebar. Click Insert and then choose the elements you want from the different galleries.\n"
				 + "Themes and styles also help keep your document coordinated. When you click Design and choose a new Theme, the pictures, charts, and SmartArt graphics change to match your new theme. When you apply styles, your headings change to match the new theme.\n"
				 + "Save time in Word with new buttons that show up where you need them. To change the way a picture fits in your document, click it and a button for layout options appears next to it. When you work on a table, click where you want to add a row or a column, and then click the plus sign.\n"
				 + "Reading is easier, too, in the new Reading view. You can collapse parts of the document and focus on the text you want. If you need to stop reading before you reach the end, Word remembers where you left off - even on another device.\n"
				);
			p.SetCharacterSpacing(4);
			document.Add(p);
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void WordSpacingTest01()
		{
			String outFileName = destinationFolder + "wordSpacingTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_wordSpacingTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA);
			Paragraph p = new Paragraph().SetFont(font);
			p.Add("Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document.\n"
				 + "To make your document look professionally produced, Word provides header, footer, cover page, and text box designs that complement each other. For example, you can add a matching cover page, header, and sidebar. Click Insert and then choose the elements you want from the different galleries.\n"
				 + "Themes and styles also help keep your document coordinated. When you click Design and choose a new Theme, the pictures, charts, and SmartArt graphics change to match your new theme. When you apply styles, your headings change to match the new theme.\n"
				 + "Save time in Word with new buttons that show up where you need them. To change the way a picture fits in your document, click it and a button for layout options appears next to it. When you work on a table, click where you want to add a row or a column, and then click the plus sign.\n"
				 + "Reading is easier, too, in the new Reading view. You can collapse parts of the document and focus on the text you want. If you need to stop reading before you reach the end, Word remembers where you left off - even on another device. "
				);
			p.Add(new Text("You can collapse parts of the document and focus.").SetBackgroundColor
				(DeviceRgb.GREEN));
			p.SetWordSpacing(15);
			document.Add(p);
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		[NUnit.Framework.Test]
		public virtual void FontStyleSimulationTest01()
		{
			String outFileName = destinationFolder + "fontStyleSimulationTest01.pdf";
			String cmpFileName = sourceFolder + "cmp_fontStyleSimulationTest01.pdf";
			PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileOutputStream(outFileName
				)));
			Document document = new Document(pdfDocument);
			document.Add(new Paragraph("I'm underlined").SetUnderline());
			document.Add(new Paragraph("I'm strikethrough").SetLineThrough());
			document.Add(new Paragraph(new Text("I'm a bold simulation font").SetBackgroundColor
				(iTextSharp.Kernel.Color.Color.GREEN)).SetBold());
			document.Add(new Paragraph(new Text("I'm an italic simulation font").SetBackgroundColor
				(iTextSharp.Kernel.Color.Color.GREEN)).SetItalic());
			document.Add(new Paragraph(new Text("I'm a super bold italic underlined linethrough piece of text and no one can be better than me, even if "
				 + "such a long description will cause me to occupy two lines").SetBackgroundColor
				(iTextSharp.Kernel.Color.Color.GREEN)).SetItalic().SetBold().SetUnderline().SetLineThrough
				());
			document.Close();
			NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName
				, destinationFolder, "diff"));
		}
	}
}