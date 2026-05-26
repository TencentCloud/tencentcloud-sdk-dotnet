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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvokeTWeSeeComprehensionRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入视频 / 图片的 URL
        /// </summary>
        [JsonProperty("InputURL")]
        public string InputURL{ get; set; }

        /// <summary>
        /// 算法类型。可选值：
        /// 
        /// - `VID_COMP`：视频理解
        /// - `IMG_COMP`：图片理解
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 任务元数据
        /// </summary>
        [JsonProperty("Metadata")]
        public SeeTaskMetadata Metadata{ get; set; }

        /// <summary>
        /// 视觉理解配置项
        /// </summary>
        [JsonProperty("ComprehensionConfig")]
        public SeeComprehensionConfig ComprehensionConfig{ get; set; }

        /// <summary>
        /// 等待结果的超时时间（单位：秒）。填 0 表示无需等待结果。最大超时时长 25 秒，默认超时时长 20 秒。
        /// </summary>
        [JsonProperty("WaitResultTimeout")]
        public long? WaitResultTimeout{ get; set; }

        /// <summary>
        /// 回调目标 ID
        /// </summary>
        [JsonProperty("CallbackId")]
        public string CallbackId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputURL", this.InputURL);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamObj(map, prefix + "ComprehensionConfig.", this.ComprehensionConfig);
            this.SetParamSimple(map, prefix + "WaitResultTimeout", this.WaitResultTimeout);
            this.SetParamSimple(map, prefix + "CallbackId", this.CallbackId);
        }
    }
}

