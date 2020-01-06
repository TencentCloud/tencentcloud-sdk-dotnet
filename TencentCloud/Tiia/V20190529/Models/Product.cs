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

    public class Product : AbstractModel
    {
        
        /// <summary>
        /// 图片中商品的三级分类识别结果，选取所有三级分类中的置信度最大者
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 三级商品分类对应的一级分类和二级分类，两级之间用“-”（中划线）隔开，例如商品名称是“硬盘”，那么Parents输出为“电脑、办公-电脑配件”
        /// </summary>
        [JsonProperty("Parents")]
        public string Parents{ get; set; }

        /// <summary>
        /// 算法对于Name的置信度，0-100之间，值越高，表示对于Name越确定
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 商品坐标X轴的最小值
        /// </summary>
        [JsonProperty("XMin")]
        public long? XMin{ get; set; }

        /// <summary>
        /// 商品坐标Y轴的最小值
        /// </summary>
        [JsonProperty("YMin")]
        public long? YMin{ get; set; }

        /// <summary>
        /// 商品坐标X轴的最大值
        /// </summary>
        [JsonProperty("XMax")]
        public long? XMax{ get; set; }

        /// <summary>
        /// 商品坐标Y轴的最大值
        /// </summary>
        [JsonProperty("YMax")]
        public long? YMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Parents", this.Parents);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "XMin", this.XMin);
            this.SetParamSimple(map, prefix + "YMin", this.YMin);
            this.SetParamSimple(map, prefix + "XMax", this.XMax);
            this.SetParamSimple(map, prefix + "YMax", this.YMax);
        }
    }
}

