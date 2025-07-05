/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGeneralApmApplicationConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务系统Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 需要修改的字段key value分别指定字段名、字段值
        /// [具体字段请见](https://cloud.tencent.com/document/product/248/111241)
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// 需要修改配置的应用列表名称	
        /// </summary>
        [JsonProperty("ServiceNames")]
        public string[] ServiceNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "ServiceNames.", this.ServiceNames);
        }
    }
}

