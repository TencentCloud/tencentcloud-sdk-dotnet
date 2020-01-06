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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DpToken : AbstractModel
    {
        
        /// <summary>
        /// 当前词父节点的序号
        /// </summary>
        [JsonProperty("HeadId")]
        public ulong? HeadId{ get; set; }

        /// <summary>
        /// 基础词的序号
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 句法依存关系的类型
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }

        /// <summary>
        /// 基础词
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeadId", this.HeadId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
            this.SetParamSimple(map, prefix + "Word", this.Word);
        }
    }
}

