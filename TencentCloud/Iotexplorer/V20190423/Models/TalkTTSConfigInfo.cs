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

    public class TalkTTSConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 支持的LLM类型，支持tencent-腾讯；azure-亚马逊；volcengine-火山引擎；elevenlabs-ELEVENLABS；minimax-MINIMAX；cartesia-CARTESIA；aliyun-阿里；系统默认-tencent。
        /// </summary>
        [JsonProperty("TTSType")]
        public string TTSType{ get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 配置信息JSON字符串，根据`TTSType`进行不同的值匹配。例如`TTSType`是`tencent`，`Config`值是`{\"AppId\":123456,\"SecretId\":\"secretId*****\",\"SecretKey\":\"SecretKey****\",\"VoiceType\":10001}`
        /// 
        /// ## tencent
        /// ```
        /// {
        ///    "AppId": 100203,
        ///    "SecretId": "XXXX",
        ///    "SecretKey": "XXXXX",
        ///   "VoiceType":123456
        /// }
        /// ```
        /// 
        /// ## azure
        /// ```
        /// {
        ///    "SubscriptionKey": 100203,
        ///    "Region": "ch-zn",
        ///    "VoiceName": "XXXXX",
        ///   "Language":"zh"
        /// }
        /// ```
        /// ## elevenlabs
        /// ```
        /// {
        ///    "ModelId": 100203,
        ///    "VoiceId": "ch-zn",
        ///    "ApiKey": "XXXXX"
        /// }
        /// ```
        /// ## minimax
        /// ```
        /// {  
        ///   "Model":"xxxx",
        ///    "ApiUrl": "346w34",
        ///    "ApiKey": "xxx",
        ///    "GroupId": "ion",
        ///   "VoiceType":"xioawei"
        /// }
        /// ```
        /// ## cartesia
        /// ```
        /// {  
        ///   "Model":"xxxx",
        ///    "ApiKey": "xxx",
        ///   "VoiceId":"xioawei"
        /// }
        /// ```
        /// ## aliyun
        /// ```
        /// {
        ///    "VoiceType": 100203,
        ///    "RegionId": "XXXX",
        ///    "ApiKey": "XXXXX"
        /// }
        /// ```
        /// ## volcengine
        /// ```
        /// {
        ///    "AppId": "346w34",
        ///    "AccessToken": "xxx",
        ///    "ResourceId": "volc.bigasr.sauc.duration",
        ///   "VoiceType":"xioawei"
        /// }
        /// ```
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 最大token数
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// PITCH
        /// </summary>
        [JsonProperty("Pitch")]
        public float? Pitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TTSType", this.TTSType);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Pitch", this.Pitch);
        }
    }
}

