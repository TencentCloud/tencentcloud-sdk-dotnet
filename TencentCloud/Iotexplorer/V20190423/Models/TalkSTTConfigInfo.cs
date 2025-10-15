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

    public class TalkSTTConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 支持的STT类型，tencent-腾讯；azure-亚马逊；volcengine-火山引擎；deepgram-Deepgram;系统默认-tencent。
        /// </summary>
        [JsonProperty("STTType")]
        public string STTType{ get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 配置信息JSON字符串，根据STTType进行不同的值匹配。例如`STTType`是`tencent`，`Config`值是`{\"AppId\":123456,\"SecretId\":\"secretId*****\",\"SecretKey\":\"SecretKey****\",\"EngineType\":\"16k_zh\"}`
        /// 
        /// ## tencent
        /// ```
        /// {
        ///   "AppId": 123456,
        ///   "SecretId": "secretId*****",
        ///   "SecretKey": "SecretKey****",
        ///   "EngineType": "16k_zh"
        /// }
        /// ```
        /// 
        /// ## azure
        /// ```
        /// {
        ///   "Region": "",
        ///   "EndpointId": "id",
        ///   "Language": "zh-CN",
        ///   "SubscriptionKey": "*****"
        /// }
        /// ```
        /// ## volcengine
        /// ```
        /// {
        ///   "AppId": 123456,
        ///   "AccessToken": "*****",
        ///   "ResourceId": "SecretKey****",
        ///   "ModelName": "16k_zh",
        ///   "Language":""
        /// }
        /// ```
        /// ## deepgram
        /// ```
        /// {
        ///   "Model": "nova-2",
        ///   "Language": "zh",
        ///    "BaseUrl":"http://www.deepgram.com",
        ///   "ApiKey": "SecretKey****"
        /// }
        /// ```
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "STTType", this.STTType);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Config", this.Config);
        }
    }
}

