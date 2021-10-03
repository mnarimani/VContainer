using System;

namespace VContainer.Internal
{
    sealed class InstanceRegistrationBuilder : RegistrationBuilder
    {
        readonly object implementationInstance;

        public InstanceRegistrationBuilder(Type type, object implementationInstance)
            : base(type, Lifetime.Singleton)
        {
            this.implementationInstance = implementationInstance;
        }

        public override IRegistration Build()
        {
            return new InstanceRegistration(
                implementationInstance,
                ImplementationType,
                Lifetime,
                InterfaceTypes);
        }
    }
}
