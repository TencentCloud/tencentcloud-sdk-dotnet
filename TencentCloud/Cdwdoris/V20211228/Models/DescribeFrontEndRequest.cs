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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFrontEndRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("ConfigType")]
        public string ConfigType{ get; set; }

        /// <summary>
        /// 参数1
        /// </summary>
        [JsonProperty("Param1")]
        public string Param1{ get; set; }

        /// <summary>
        /// 参数2
        /// </summary>
        [JsonProperty("Param2")]
        public string Param2{ get; set; }

        /// <summary>
        /// 参数3
        /// </summary>
        [JsonProperty("Param3")]
        public string Param3{ get; set; }

        /// <summary>
        /// 参数4
        /// </summary>
        [JsonProperty("Param4")]
        public string Param4{ get; set; }

        /// <summary>
        /// 参数5
        /// </summary>
        [JsonProperty("Param5")]
        public string Param5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "Param1", this.Param1);
            this.SetParamSimple(map, prefix + "Param2", this.Param2);
            this.SetParamSimple(map, prefix + "Param3", this.Param3);
            this.SetParamSimple(map, prefix + "Param4", this.Param4);
            this.SetParamSimple(map, prefix + "Param5", this.Param5);
        }
    }
}

