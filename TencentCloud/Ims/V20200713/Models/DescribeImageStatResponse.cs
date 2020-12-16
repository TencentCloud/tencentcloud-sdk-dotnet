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

namespace TencentCloud.Ims.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageStatResponse : AbstractModel
    {
        
        /// <summary>
        /// 识别结果统计
        /// </summary>
        [JsonProperty("Overview")]
        public Overview Overview{ get; set; }

        /// <summary>
        /// 识别量统计
        /// </summary>
        [JsonProperty("TrendCount")]
        public TrendCount[] TrendCount{ get; set; }

        /// <summary>
        /// 违规数据分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilCount")]
        public EvilCount[] EvilCount{ get; set; }

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
            this.SetParamObj(map, prefix + "Overview.", this.Overview);
            this.SetParamArrayObj(map, prefix + "TrendCount.", this.TrendCount);
            this.SetParamArrayObj(map, prefix + "EvilCount.", this.EvilCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

