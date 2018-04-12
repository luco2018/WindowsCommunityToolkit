// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.ComponentModel;
using Microsoft.Toolkit.Win32.UI.Controls.Test.WebView.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace Microsoft.Toolkit.Win32.UI.Controls.Test.WinForms.WebView.FunctionalTests.Ctor
{
    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class ScriptNotifyPropertySetBetweenBeginEndInit : BlockTestStartEndContextSpecification
    {
        protected override void CreateWebView()
        {
            WebView = new UI.Controls.WinForms.WebView();
        }

        protected override void When()
        {
            ((ISupportInitialize)WebView).BeginInit();
            WebView.IsScriptNotifyAllowed = false;
            ((ISupportInitialize)WebView).EndInit();
        }

        [TestMethod]
        public void ScriptNotifyIsDisabled()
        {
            WebView.IsScriptNotifyAllowed.ShouldBeFalse();
            WebView.Settings.IsScriptNotifyAllowed.ShouldBeFalse();
            WebView.Settings.IsScriptNotifyAllowed.ShouldEqual(WebView.IsScriptNotifyAllowed);
        }

        protected override void Cleanup()
        {
            WebView.Dispose();
            base.Cleanup();
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class ScriptNotifyPropertySetAfterEndInit : HostFormWebViewContextSpecification
    {
        private bool _expected;

        protected override void Given()
        {
            base.Given();
            _expected = WebView.IsScriptNotifyAllowed != true;
        }

        protected override void When()
        {
            WebView.IsScriptNotifyAllowed = _expected;
        }

        [TestMethod]
        public void PropertyEqualsSettingsValue()
        {
            WebView.Settings.IsScriptNotifyAllowed.ShouldEqual(WebView.IsScriptNotifyAllowed);
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class ScriptNotifySettingSetAfterEndInit : HostFormWebViewContextSpecification
    {
        private bool _expected;

        protected override void Given()
        {
            base.Given();
            _expected = WebView.IsScriptNotifyAllowed != true;
        }

        protected override void When()
        {
            WebView.Settings.IsScriptNotifyAllowed = _expected;
        }

        [TestMethod]
        public void PropertyEqualsSettingsValue()
        {
            WebView.IsScriptNotifyAllowed.ShouldEqual(WebView.Settings.IsScriptNotifyAllowed);
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class JavaScriptPropertySetBetweenBeginEndInit : BlockTestStartEndContextSpecification
    {
        protected override void CreateWebView()
        {
            WebView = new UI.Controls.WinForms.WebView();
        }

        protected override void When()
        {
            ((ISupportInitialize)WebView).BeginInit();
            WebView.IsJavaScriptEnabled = false;
            ((ISupportInitialize)WebView).EndInit();
        }

        [TestMethod]
        public void ScriptNotifyIsDisabled()
        {
            WebView.IsJavaScriptEnabled.ShouldBeFalse();
            WebView.Settings.IsJavaScriptEnabled.ShouldBeFalse();
            WebView.Settings.IsJavaScriptEnabled.ShouldEqual(WebView.IsJavaScriptEnabled);
        }

        protected override void Cleanup()
        {
            WebView.Close();
            base.Cleanup();
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class JavaScriptPropertySetAfterEndInit : HostFormWebViewContextSpecification
    {
        private bool _expected;

        protected override void Given()
        {
            base.Given();
            _expected = WebView.IsJavaScriptEnabled != true;
        }

        protected override void When()
        {
            WebView.IsJavaScriptEnabled = _expected;
        }

        [TestMethod]
        public void PropertyEqualsSettingsValue()
        {
            WebView.Settings.IsJavaScriptEnabled.ShouldEqual(WebView.IsJavaScriptEnabled);
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class JavaScriptSettingSetAfterEndInit : HostFormWebViewContextSpecification
    {
        private bool _expected;

        protected override void Given()
        {
            base.Given();
            _expected = WebView.IsJavaScriptEnabled != true;
        }

        protected override void When()
        {
            WebView.Settings.IsJavaScriptEnabled = _expected;
        }

        [TestMethod]
        public void PropertyEqualsSettingsValue()
        {
            WebView.IsJavaScriptEnabled.ShouldEqual(WebView.Settings.IsJavaScriptEnabled);
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class IndexDbPropertySetAfterEndInit : HostFormWebViewContextSpecification
    {
        private bool _expected;

        protected override void Given()
        {
            base.Given();
            _expected = WebView.IsIndexDBEnabled != true;
        }

        protected override void When()
        {
            WebView.IsIndexDBEnabled = _expected;
        }

        [TestMethod]
        public void PropertyEqualsSettingsValue()
        {
            WebView.Settings.IsIndexedDBEnabled.ShouldEqual(WebView.IsIndexDBEnabled);
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class IndexDbSettingSetAfterEndInit : HostFormWebViewContextSpecification
    {
        private bool _expected;

        protected override void Given()
        {
            base.Given();
            _expected = WebView.IsIndexDBEnabled != true;
        }

        protected override void When()
        {
            WebView.Settings.IsIndexedDBEnabled = _expected;
        }

        [TestMethod]
        public void PropertyEqualsSettingsValue()
        {
            WebView.IsIndexDBEnabled.ShouldEqual(WebView.Settings.IsIndexedDBEnabled);
        }
    }

    [TestClass]
    [TestCategory(TestConstants.Categories.Init)]
    public class IndexDbPropertySetBetweenBeginEndInit : BlockTestStartEndContextSpecification
    {
        protected override void CreateWebView()
        {
            WebView = new UI.Controls.WinForms.WebView();
        }

        protected override void When()
        {
            // Behavior like the designer
            ((ISupportInitialize)WebView).BeginInit();
            WebView.IsIndexDBEnabled = false;
            ((ISupportInitialize)WebView).EndInit();
        }

        [TestMethod]
        public void ScriptNotifyIsDisabled()
        {
            WebView.IsIndexDBEnabled.ShouldBeFalse();
            WebView.Settings.IsIndexedDBEnabled.ShouldBeFalse();
            WebView.Settings.IsIndexedDBEnabled.ShouldEqual(WebView.IsIndexDBEnabled);
        }

        protected override void Cleanup()
        {
            WebView.Close();
            base.Cleanup();
        }
    }
}
