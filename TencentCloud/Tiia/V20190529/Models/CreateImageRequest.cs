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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 图库ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 物品ID，最多支持64个字符。 
        /// 若EntityId已存在，则对其追加图片。
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// 图片名称，最多支持64个字符， 
        /// 同一个EntityId，最大支持10张图。如果图片名称已存在，则会更新库中的图片。
        /// </summary>
        [JsonProperty("PicName")]
        public string PicName{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。  
        /// Url、Image必须提供一个，如果都提供，只使用 Url。 
        /// 图片分辨率不超过4096*4096。
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。 
        /// 图片分辨率不超过4096*4096。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 用户自定义的内容，最多支持4096个字符，查询时原样带回。
        /// </summary>
        [JsonProperty("CustomContent")]
        public string CustomContent{ get; set; }

        /// <summary>
        /// 图片自定义标签，最多不超过10个，格式为JSON。
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "PicName", this.PicName);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "CustomContent", this.CustomContent);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
        }
    }
}

