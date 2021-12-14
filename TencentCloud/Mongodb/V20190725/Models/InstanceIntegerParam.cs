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

    public class InstanceIntegerParam : AbstractModel
    {
        
        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// 是否徐亚哦重启后生效 1:需要重启；0:无需重启
        /// </summary>
        [JsonProperty("NeedRestart")]
        public string NeedRestart{ get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 参数说明
        /// </summary>
        [JsonProperty("Tips")]
        public string[] Tips{ get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// 是否正常获取到，1：未正常获取；0：正常获取，仅对前端有实际意义；
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 暂时未用到，前端使用redis侧代码，为了兼容，保留该参数
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamArraySimple(map, prefix + "Tips.", this.Tips);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

