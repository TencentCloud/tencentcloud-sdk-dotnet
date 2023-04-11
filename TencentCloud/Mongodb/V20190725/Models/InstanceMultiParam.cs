/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceMultiParam : AbstractModel
    {
        
        /// <summary>
        /// 参数当前值。
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 参数默认值。
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 参考值范围。
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// 参数修改后是否需要重启才会生效。
        /// - 1：需要重启后生效。
        /// - 0：无需重启，设置成功即可生效。
        /// </summary>
        [JsonProperty("NeedRestart")]
        public string NeedRestart{ get; set; }

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 是否为运行中参数值。
        /// - 1：运行中参数值。
        /// - 0：非运行中参数值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 参数说明。
        /// </summary>
        [JsonProperty("Tips")]
        public string[] Tips{ get; set; }

        /// <summary>
        /// 当前值的类型描述，默认为multi。
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Tips.", this.Tips);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
        }
    }
}

