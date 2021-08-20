#pragma once

#include "App.h"
#include "Wrapper.g.h"

namespace winrt::CppUwpApp::implementation
{
	struct Wrapper : WrapperT<Wrapper>
	{
		Wrapper();
		void Close();
	private:
		App_base<App, Windows::UI::Xaml::Markup::IXamlMetadataProvider>::class_type m_app_ = nullptr;
	};
}

namespace winrt::CppUwpApp::factory_implementation
{
	struct Wrapper : WrapperT<Wrapper, implementation::Wrapper>
	{
	};
}
