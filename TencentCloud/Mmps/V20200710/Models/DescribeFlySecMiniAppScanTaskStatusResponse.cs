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

namespace TencentCloud.Mmps.V20200710.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFlySecMiniAppScanTaskStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回值, 0:成功, 其他值请查看“返回值”定义
        /// </summary>
        [JsonProperty("Ret")]
        public long? Ret{ get; set; }

        /// <summary>
        /// 诊断状态, 0:排队中, 1:成功, 2:失败, 3:进行中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 诊断失败错误码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Errno")]
        public long? Errno{ get; set; }

        /// <summary>
        /// 小程序名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniAppName")]
        public string MiniAppName{ get; set; }

        /// <summary>
        /// 小程序版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniAppVersion")]
        public string MiniAppVersion{ get; set; }

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
            this.SetParamSimple(map, prefix + "Ret", this.Ret);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Errno", this.Errno);
            this.SetParamSimple(map, prefix + "MiniAppName", this.MiniAppName);
            this.SetParamSimple(map, prefix + "MiniAppVersion", this.MiniAppVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

