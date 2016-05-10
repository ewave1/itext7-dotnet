using System;
using NUnit.Framework;

namespace com.itextpdf.io.image
{
	public class TiffTest
	{
        public const String sourceFolder = @"..\..\resources\image\";

		/// <exception cref="System.IO.IOException"/>
		[Test]
		public virtual void OpenTiff1()
		{
			ImageData img = ImageDataFactory.Create(sourceFolder + "WP_20140410_001.tif");
			NUnit.Framework.Assert.AreEqual(2592, img.GetWidth(), 0);
			NUnit.Framework.Assert.AreEqual(1456, img.GetHeight(), 0);
			NUnit.Framework.Assert.AreEqual(8, img.GetBpc());
		}

		/// <exception cref="System.IO.IOException"/>
		[Test]
		public virtual void OpenTiff2()
		{
			ImageData img = ImageDataFactory.Create(sourceFolder + "WP_20140410_001_gray.tiff"
				);
			NUnit.Framework.Assert.AreEqual(2592, img.GetWidth(), 0);
			NUnit.Framework.Assert.AreEqual(1456, img.GetHeight(), 0);
			NUnit.Framework.Assert.AreEqual(8, img.GetBpc());
		}

		/// <exception cref="System.IO.IOException"/>
		[Test]
		public virtual void OpenTiff3()
		{
			ImageData img = ImageDataFactory.Create(sourceFolder + "WP_20140410_001_monochrome.tiff"
				);
			NUnit.Framework.Assert.AreEqual(2592, img.GetWidth(), 0);
			NUnit.Framework.Assert.AreEqual(1456, img.GetHeight(), 0);
			NUnit.Framework.Assert.AreEqual(8, img.GetBpc());
		}

		/// <exception cref="System.IO.IOException"/>
		[Test]
		public virtual void OpenTiff4()
		{
			ImageData img = ImageDataFactory.Create(sourceFolder + "WP_20140410_001_negate.tiff"
				);
			NUnit.Framework.Assert.AreEqual(2592, img.GetWidth(), 0);
			NUnit.Framework.Assert.AreEqual(1456, img.GetHeight(), 0);
			NUnit.Framework.Assert.AreEqual(8, img.GetBpc());
		}

		/// <exception cref="System.IO.IOException"/>
		[Test]
		public virtual void OpenTiff5()
		{
			ImageData img = ImageDataFactory.Create(sourceFolder + "WP_20140410_001_year1900.tiff"
				);
			NUnit.Framework.Assert.AreEqual(2592, img.GetWidth(), 0);
			NUnit.Framework.Assert.AreEqual(1456, img.GetHeight(), 0);
			NUnit.Framework.Assert.AreEqual(8, img.GetBpc());
		}

		/// <exception cref="System.IO.IOException"/>
		[Test]
		public virtual void OpenTiff6()
		{
			ImageData img = ImageDataFactory.Create(sourceFolder + "WP_20140410_001_year1980.tiff"
				);
			NUnit.Framework.Assert.AreEqual(2592, img.GetWidth(), 0);
			NUnit.Framework.Assert.AreEqual(1456, img.GetHeight(), 0);
			NUnit.Framework.Assert.AreEqual(8, img.GetBpc());
		}
	}
}