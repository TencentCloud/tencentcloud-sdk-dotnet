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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ThirdPartyPublishInfo : AbstractModel
    {
        
        /// <summary>
        /// 发布通道  ID。
        /// </summary>
        [JsonProperty("ChannelMaterialId")]
        public string ChannelMaterialId{ get; set; }

        /// <summary>
        /// 企鹅号发布信息，如果使用的发布通道为企鹅号时必填。
        /// </summary>
        [JsonProperty("PenguinMediaPlatformPublishInfo")]
        public PenguinMediaPlatformPublishInfo PenguinMediaPlatformPublishInfo{ get; set; }

        /// <summary>
        /// 新浪微博发布信息，如果使用的发布通道为新浪微博时必填。
        /// </summary>
        [JsonProperty("WeiboPublishInfo")]
        public WeiboPublishInfo WeiboPublishInfo{ get; set; }

        /// <summary>
        /// 快手发布信息，如果使用的发布通道为快手时必填。
        /// </summary>
        [JsonProperty("KuaishouPublishInfo")]
        public KuaishouPublishInfo KuaishouPublishInfo{ get; set; }

        /// <summary>
        /// 腾讯云对象存储发布信息， 如果使用的发布通道为腾讯云对象存储时必填。
        /// </summary>
        [JsonProperty("CosPublishInfo")]
        public CosPublishInputInfo CosPublishInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMaterialId", this.ChannelMaterialId);
            this.SetParamObj(map, prefix + "PenguinMediaPlatformPublishInfo.", this.PenguinMediaPlatformPublishInfo);
            this.SetParamObj(map, prefix + "WeiboPublishInfo.", this.WeiboPublishInfo);
            this.SetParamObj(map, prefix + "KuaishouPublishInfo.", this.KuaishouPublishInfo);
            this.SetParamObj(map, prefix + "CosPublishInfo.", this.CosPublishInfo);
        }
    }
}

