#pragma once
#include "App.g.h"
#include "App.base.h"

namespace winrt::CustomControlsWrapper::implementation
{
    struct App : public AppT2<App>
    {
    public:
        App();
        ~App();
    };
}

namespace winrt::CustomControlsWrapper::factory_implementation
{
	struct App : public AppT<App, implementation::App>
	{
	};
}