#include "pch.h"
#include "Wrapper.h"

#include "App.h"
#include "Wrapper.g.cpp"

namespace winrt::CppUwpApp::implementation
{
	Wrapper::Wrapper()
	{
		m_app_ = winrt::make<App>();
	}

	void Wrapper::Close()
	{
		m_app_.Close();
	}
}
