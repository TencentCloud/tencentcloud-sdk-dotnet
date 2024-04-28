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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeGeneralTextImageWarnResponse : AbstractModel
    {
        
        /// <summary>
        /// 复印告警信息
        /// </summary>
        [JsonProperty("Copy")]
        public GeneralWarnInfo Copy{ get; set; }

        /// <summary>
        /// 翻拍告警信息
        /// </summary>
        [JsonProperty("Reprint")]
        public GeneralWarnInfo Reprint{ get; set; }

        /// <summary>
        /// 模糊告警信息
        /// </summary>
        [JsonProperty("Blur")]
        public GeneralWarnInfo Blur{ get; set; }

        /// <summary>
        /// 反光告警信息
        /// </summary>
        [JsonProperty("Reflection")]
        public GeneralWarnInfo Reflection{ get; set; }

        /// <summary>
        /// 边框不完整告警信息
        /// </summary>
        [JsonProperty("BorderIncomplete")]
        public GeneralWarnInfo BorderIncomplete{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Copy.", this.Copy);
            this.SetParamObj(map, prefix + "Reprint.", this.Reprint);
            this.SetParamObj(map, prefix + "Blur.", this.Blur);
            this.SetParamObj(map, prefix + "Reflection.", this.Reflection);
            this.SetParamObj(map, prefix + "BorderIncomplete.", this.BorderIncomplete);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

