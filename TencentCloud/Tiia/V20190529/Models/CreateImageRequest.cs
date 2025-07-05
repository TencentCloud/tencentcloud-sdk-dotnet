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
        /// 一个物品ID可以包含多张图片，若EntityId已存在，则对其追加图片。同一个EntityId，最大支持10张图。
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// 图片名称，最多支持64个字符， 
        /// PicName唯一确定一张图片，具有唯一性。
        /// </summary>
        [JsonProperty("PicName")]
        public string PicName{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。  
        /// ImageUrl和ImageBase64必须提供一个，如果都提供，只使用ImageUrl。
        /// 图片限制：
        /// • 图片格式：支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// • 图片大小：对应图片 base64 编码后大小不可超过5M。图片分辨率不超过4096\*4096。
        /// • 如果在商品图像搜索中开启主体识别，分辨率不超过2000\*2000，图片长宽比小于10。
        /// 建议：
        /// • 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片自定义备注内容，最多支持4096个字符，查询时原样带回。
        /// </summary>
        [JsonProperty("CustomContent")]
        public string CustomContent{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。 
        /// 图片限制：
        /// • 图片格式：支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// • 图片大小：base64 编码后大小不可超过5M。图片分辨率不超过4096\*4096。
        /// • 如果在商品图像搜索中开启主体识别，分辨率不超过2000\*2000，图片长宽比小于10。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片自定义标签，最多不超过10个，格式为JSON。
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 是否需要启用主体识别，默认为**TRUE**。
        /// • 为**TRUE**时，启用主体识别，返回主体信息。若没有指定**ImageRect**，自动提取最大面积主体创建图片并进行主体识别。主体识别结果可在**Response**中获取。
        /// • 为**FALSE**时，不启用主体识别，不返回主体信息。若没有指定**ImageRect**，以整张图创建图片。
        /// **<font color=#1E90FF>注意：仅服务类型为商品图像搜索时才生效。</font>**
        /// </summary>
        [JsonProperty("EnableDetect")]
        public bool? EnableDetect{ get; set; }

        /// <summary>
        /// 图像类目ID。
        /// 若设置类目ID，提取以下类目的主体创建图片。
        /// 类目取值说明：
        /// 0：上衣。
        /// 1：裙装。
        /// 2：下装。
        /// 3：包。
        /// 4：鞋。
        /// 5：配饰。
        /// **<font color=#1E90FF>注意：仅服务类型为商品图像搜索时才生效。</font>**
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 图像主体区域。
        /// 若设置主体区域，提取指定的区域创建图片。
        /// </summary>
        [JsonProperty("ImageRect")]
        public Rect ImageRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "PicName", this.PicName);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "CustomContent", this.CustomContent);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "EnableDetect", this.EnableDetect);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamObj(map, prefix + "ImageRect.", this.ImageRect);
        }
    }
}

