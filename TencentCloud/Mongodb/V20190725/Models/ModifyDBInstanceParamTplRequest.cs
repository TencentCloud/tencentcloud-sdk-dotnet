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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceParamTplRequest : AbstractModel
    {
        
        /// <summary>
        /// 待修改的参数模板 ID，示例：tpl-jglr91vew。
        /// </summary>
        [JsonProperty("TplId")]
        public string TplId{ get; set; }

        /// <summary>
        /// 待修改参数模板名称，为空时，保持原有名称。
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// 待修改参数模板描述，为空时，保持原有描述。
        /// </summary>
        [JsonProperty("TplDesc")]
        public string TplDesc{ get; set; }

        /// <summary>
        /// 待修改参数名及参数值，为空时，各参数保持原有值，支持单条或批量修改。
        /// </summary>
        [JsonProperty("Params")]
        public ParamType[] Params{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TplId", this.TplId);
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "TplDesc", this.TplDesc);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
        }
    }
}

