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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TurnPDFToObjectAsyncGetResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 报告结构化结果
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// 多级分类结果
        /// </summary>
        [JsonProperty("TextTypeList")]
        public TextType[] TextTypeList{ get; set; }

        /// <summary>
        /// 报告结构化结果(体检报告PDF结构化接口返回的 json 内容非常多，建议通过本地代码调用)
        /// </summary>
        [JsonProperty("Block")]
        public Block Block{ get; set; }

        /// <summary>
        /// 是否使用Block字段
        /// </summary>
        [JsonProperty("IsBlock")]
        public bool? IsBlock{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamArrayObj(map, prefix + "TextTypeList.", this.TextTypeList);
            this.SetParamObj(map, prefix + "Block.", this.Block);
            this.SetParamSimple(map, prefix + "IsBlock", this.IsBlock);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

