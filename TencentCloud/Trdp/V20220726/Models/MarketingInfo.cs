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

namespace TencentCloud.Trdp.V20220726.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MarketingInfo : AbstractModel
    {
        
        /// <summary>
        /// 投放模式（0=PDB，1=PD，2=RTB，10=其他）
        /// </summary>
        [JsonProperty("DeliveryMode")]
        public long? DeliveryMode{ get; set; }

        /// <summary>
        /// 广告位类型 （0=前贴片，1=开屏广告，2=网页头部广告、3=网页中部广告、4=网页底部广告、5=悬浮广告、10=其它）
        /// </summary>
        [JsonProperty("AdvertisingType")]
        public long? AdvertisingType{ get; set; }

        /// <summary>
        /// 是否全屏插广告（0-否，1-是）
        /// </summary>
        [JsonProperty("FullScreen")]
        public long? FullScreen{ get; set; }

        /// <summary>
        /// 广告位宽度
        /// </summary>
        [JsonProperty("AdvertisingSpaceWidth")]
        public long? AdvertisingSpaceWidth{ get; set; }

        /// <summary>
        /// 广告位高度
        /// </summary>
        [JsonProperty("AdvertisingSpaceHeight")]
        public long? AdvertisingSpaceHeight{ get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeliveryMode", this.DeliveryMode);
            this.SetParamSimple(map, prefix + "AdvertisingType", this.AdvertisingType);
            this.SetParamSimple(map, prefix + "FullScreen", this.FullScreen);
            this.SetParamSimple(map, prefix + "AdvertisingSpaceWidth", this.AdvertisingSpaceWidth);
            this.SetParamSimple(map, prefix + "AdvertisingSpaceHeight", this.AdvertisingSpaceHeight);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

