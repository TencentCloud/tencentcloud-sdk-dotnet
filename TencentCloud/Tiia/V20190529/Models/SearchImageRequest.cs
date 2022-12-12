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
        /// 图片的 Url 。
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
        /// 图片 base64 数据。
        /// ImageUrl和ImageBase64必须提供一个，如果都提供，只使用ImageUrl。
        /// 图片限制：
        /// • 图片格式：支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// • 图片大小：base64 编码后大小不可超过5M。图片分辨率不超过4096\*4096。
        /// • 如果在商品图像搜索中开启主体识别，分辨率不超过2000\*2000，图片长宽比小于10。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 返回结果的数量，默认值为10，最大值为100。
        /// 按照相似度分数由高到低排序。
        /// **<font color=#1E90FF>服务类型为图案花纹搜索时Limit = 1，最多只能返回1个结果。</font>**
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 返回结果的起始序号，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 匹配阈值。
        /// 只有图片相似度分数超过匹配阈值的结果才会返回。
        /// 当MatchThreshold为0（默认值）时，各服务类型将按照以下默认的匹配阈值进行结果过滤：
        /// • 通用图像搜索1.0版：50。
        /// • 商品图像搜索2.0升级版：45。
        /// • 商品图像搜索1.0版：28。
        /// • 图案花纹搜索1.0版：56。
        /// 建议：
        /// 可以手动调整MatchThreshold值来控制输出结果的范围。如果发现无检索结果，可能是因为图片相似度较低导致检索结果被匹配阈值过滤，建议调整为较低的阈值后再次尝试检索。
        /// </summary>
        [JsonProperty("MatchThreshold")]
        public long? MatchThreshold{ get; set; }

        /// <summary>
        /// 标签过滤条件。
        /// 针对创建图片时提交的Tags信息进行条件过滤。支持>、>=、 <、 <=、=，!=，多个条件之间支持AND和OR进行连接。
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
        /// • 为**TRUE**时，启用主体识别，返回主体信息。若没有指定**ImageRect**，自动提取最大面积主体进行检索并进行主体识别。主体识别结果可在**Response中**获取。
        /// • 为**FALSE**时，不启用主体识别，不返回主体信息。若没有指定**ImageRect**，以整张图检索图片。
        /// **<font color=#1E90FF>注意：仅服务类型为商品图像搜索时才生效。</font>**
        /// </summary>
        [JsonProperty("EnableDetect")]
        public bool? EnableDetect{ get; set; }

        /// <summary>
        /// 图像类目ID。
        /// 若设置类目ID，提取以下类目的主体进行检索。
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

