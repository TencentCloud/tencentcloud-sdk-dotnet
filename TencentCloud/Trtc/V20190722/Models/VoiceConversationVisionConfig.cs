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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoiceConversationVisionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>是否启用视觉理解。</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>存储类型。</p><p>枚举值：</p><ul><li>0： 不存储。</li><li>1： 指定云存储，这种情况下CloudStorage参数必填。</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public ulong? StorageType{ get; set; }

        /// <summary>
        /// <p>第三方云存储归档配置。配置后，后台将从 SDK 收到的 I 帧自动上传至指定云存储桶进行持久化保存。</p>
        /// </summary>
        [JsonProperty("CloudStorage")]
        public CloudStorage CloudStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamObj(map, prefix + "CloudStorage.", this.CloudStorage);
        }
    }
}

