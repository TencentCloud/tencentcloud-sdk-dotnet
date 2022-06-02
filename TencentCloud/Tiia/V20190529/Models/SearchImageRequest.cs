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

    public class SearchImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 图库名称。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。 
        /// 图片分辨率不超4096\*4096。 
        /// Url、Image必须提供一个，如果都提供，只使用 Url。 
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// 注意：开启主体识别分辨率不超过2000\*2000，图片长宽比小于10（长/短 < 10）。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。 
        /// 图片分辨率不超过4096\*4096。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// 注意：开启主体识别分辨率不超过2000\*2000，图片长宽比小于10（长/短 < 10）。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 返回数量，默认值为10，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 起始序号，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 出参Score中，只有超过**MatchThreshold**值的结果才会返回。默认为0
        /// </summary>
        [JsonProperty("MatchThreshold")]
        public long? MatchThreshold{ get; set; }

        /// <summary>
        /// 针对入库时提交的Tags信息进行条件过滤。支持>、>=、 <、 <=、=，!=，多个条件之间支持AND和OR进行连接。
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 图像主体区域。
        /// 若设置主体区域，提取指定的区域进行检索。
        /// </summary>
        [JsonProperty("ImageRect")]
        public ImageRect ImageRect{ get; set; }

        /// <summary>
        /// 是否需要启用主体识别，默认为**TRUE** 。
        /// 1. 为**TRUE**时，启用主体识别，返回主体信息。若没有指定**ImageRect**，自动提取最大面积主体进行检索并进行主体识别。主体识别结果可在**Response中**获取。
        /// 2. 为**FALSE**时，不启用主体识别，不返回主体信息。若没有指定**ImageRect**，以整张图检索图片。
        /// 注意：服务类型为商品图像搜索时生效。
        /// </summary>
        [JsonProperty("EnableDetect")]
        public bool? EnableDetect{ get; set; }

        /// <summary>
        /// 图像类目ID。
        /// 若设置类目ID，提取对应类目的主体进行检索。
        /// 注意：服务类型为商品图像搜索时生效。
        /// 类目信息：
        /// 0：上衣。
        /// 1：裙装。
        /// 2：下装。
        /// 3：包。
        /// 4：鞋。
        /// 5：配饰。
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "MatchThreshold", this.MatchThreshold);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamObj(map, prefix + "ImageRect.", this.ImageRect);
            this.SetParamSimple(map, prefix + "EnableDetect", this.EnableDetect);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
        }
    }
}

