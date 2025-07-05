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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// SDK 对应的AppId 
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// 应用配置
        /// </summary>
        [JsonProperty("AppConfig")]
        public AppConfig AppConfig{ get; set; }

        /// <summary>
        /// 场景配置
        /// </summary>
        [JsonProperty("SceneConfig")]
        public SceneItem[] SceneConfig{ get; set; }

        /// <summary>
        /// 转存配置
        /// </summary>
        [JsonProperty("TransferConfig")]
        public TransferItem TransferConfig{ get; set; }

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
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamObj(map, prefix + "AppConfig.", this.AppConfig);
            this.SetParamArrayObj(map, prefix + "SceneConfig.", this.SceneConfig);
            this.SetParamObj(map, prefix + "TransferConfig.", this.TransferConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

