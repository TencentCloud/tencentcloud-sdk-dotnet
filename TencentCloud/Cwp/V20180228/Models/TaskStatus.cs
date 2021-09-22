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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskStatus : AbstractModel
    {
        
        /// <summary>
        /// 扫描中（包含初始化）
        /// </summary>
        [JsonProperty("Scanning")]
        public string Scanning{ get; set; }

        /// <summary>
        /// 扫描终止（包含终止中）
        /// </summary>
        [JsonProperty("Ok")]
        public string Ok{ get; set; }

        /// <summary>
        /// 扫描失败
        /// </summary>
        [JsonProperty("Fail")]
        public string Fail{ get; set; }

        /// <summary>
        /// 扫描失败（提示具体原因：扫描超时、客户端版本低、客户端离线）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Stop")]
        public string Stop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scanning", this.Scanning);
            this.SetParamSimple(map, prefix + "Ok", this.Ok);
            this.SetParamSimple(map, prefix + "Fail", this.Fail);
            this.SetParamSimple(map, prefix + "Stop", this.Stop);
        }
    }
}

