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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCRObtainStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 侵权ID
        /// </summary>
        [JsonProperty("TortId")]
        public long? TortId{ get; set; }

        /// <summary>
        /// 取证类型：1-网页取证 2-过程取证
        /// </summary>
        [JsonProperty("ObtainType")]
        public long? ObtainType{ get; set; }

        /// <summary>
        /// 过程取证的取证时长，单位分钟，范围0-120
        /// </summary>
        [JsonProperty("ObtainDuration")]
        public long? ObtainDuration{ get; set; }

        /// <summary>
        /// 结果回调地址
        /// </summary>
        [JsonProperty("ObtainUrl")]
        public string ObtainUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TortId", this.TortId);
            this.SetParamSimple(map, prefix + "ObtainType", this.ObtainType);
            this.SetParamSimple(map, prefix + "ObtainDuration", this.ObtainDuration);
            this.SetParamSimple(map, prefix + "ObtainUrl", this.ObtainUrl);
        }
    }
}

