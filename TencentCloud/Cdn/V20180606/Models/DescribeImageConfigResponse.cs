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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// WebpAdapter配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebpAdapter")]
        public WebpAdapter WebpAdapter{ get; set; }

        /// <summary>
        /// TpgAdapter配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TpgAdapter")]
        public TpgAdapter TpgAdapter{ get; set; }

        /// <summary>
        /// GuetzliAdapter配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GuetzliAdapter")]
        public GuetzliAdapter GuetzliAdapter{ get; set; }

        /// <summary>
        /// AvifAdapter配置项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvifAdapter")]
        public AvifAdapter AvifAdapter{ get; set; }

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
            this.SetParamObj(map, prefix + "WebpAdapter.", this.WebpAdapter);
            this.SetParamObj(map, prefix + "TpgAdapter.", this.TpgAdapter);
            this.SetParamObj(map, prefix + "GuetzliAdapter.", this.GuetzliAdapter);
            this.SetParamObj(map, prefix + "AvifAdapter.", this.AvifAdapter);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

