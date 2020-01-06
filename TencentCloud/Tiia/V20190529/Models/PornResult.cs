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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PornResult : AbstractModel
    {
        
        /// <summary>
        /// 该识别场景的错误码：
        /// 0表示成功，
        /// -1表示系统错误，
        /// -2表示引擎错误，
        /// -1400表示图片解码失败。
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 错误码描述信息。
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 识别场景的审核结论：
        /// PASS：正常
        /// REVIEW：疑似
        /// BLOCK：违规
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 算法对于Suggestion的置信度，0-100之间，值越高，表示对于Suggestion越确定。
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 预留字段，后期用于展示更多识别信息。
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// 色情识别类型：
        /// PORN：色情
        /// HOT：性感
        /// NORMAL：正常
        /// FAIL：识别失败
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

