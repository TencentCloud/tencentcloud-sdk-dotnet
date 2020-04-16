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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Trace : AbstractModel
    {
        
        /// <summary>
        /// 人体轨迹图片 Base64 数组。 
        /// 数组长度最小为1最大为5。 
        /// 单个图片 base64 编码后大小不可超过2M。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 人体轨迹图片 Url 数组。 
        /// 数组长度最小为1最大为5。 
        /// 单个图片 base64 编码后大小不可超过2M。 
        /// Urls、Images必须提供一个，如果都提供，只使用 Urls。 
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 若输入的Images 和 Urls 是已经裁剪后的人体小图，则可以忽略本参数。 
        /// 若否，或图片中包含多个人体，则需要通过本参数来指定图片中的人体框。 
        /// 顺序对应 Images 或 Urls 中的顺序。  
        /// 当不输入本参数时，我们将认为输入图片已是经过裁剪后的人体小图，不会进行人体检测而直接进行特征提取处理。
        /// </summary>
        [JsonProperty("BodyRects")]
        public BodyRect[] BodyRects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamArrayObj(map, prefix + "BodyRects.", this.BodyRects);
        }
    }
}

