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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdgeArgsFlag : AbstractModel
    {
        
        /// <summary>
        /// 参数名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// 参数默认值
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 参数可选范围（目前包含range和in两种，"[]"代表range，如"[1, 5]"表示参数必须>=1且 <=5, "()"代表in， 如"('aa', 'bb')"表示参数只能为字符串'aa'或者'bb'，该参数为空表示不校验）
        /// </summary>
        [JsonProperty("Constraint")]
        public string Constraint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "Constraint", this.Constraint);
        }
    }
}

