﻿using System;
using System.Runtime;
using System.Runtime.CompilerServices;
using Mono;
using Mono.Cecil;

namespace Mono.Cecil
{
    static internal class __ModuleDefinition
    {
        static public TypeDefinition Type(this ModuleDefinition module, string name, TypeAttributes attributes)
        {
            var _type = new TypeDefinition(null, name, attributes, module.TypeSystem.Object);
            module.Types.Add(_type);
            _type.Attribute<CompilerGeneratedAttribute>();
            return _type;
        }
    }
}
