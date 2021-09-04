#include "pch.h"

#include "App.h"
#include "App.g.cpp"

using namespace winrt;
using namespace Windows::ApplicationModel;
using namespace Windows::ApplicationModel::Activation;
using namespace Windows::Foundation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;
using namespace CustomControlsWrapper;
using namespace CustomControlsWrapper::implementation;

namespace winrt::CustomControlsWrapper::implementation
{
	/// <summary>
	/// Initializes the singleton application object.  This is the first line of authored code
	/// executed, and as such is the logical equivalent of main() or WinMain().
	/// </summary>
	App::App()
	{
		Initialize();
		AddRef();
		m_inner.as<::IUnknown>()->Release();
	}

	App::~App()
	{
		Close();
	}

}