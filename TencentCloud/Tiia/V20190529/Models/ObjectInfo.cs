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

    public class ObjectInfo : AbstractModel
    {
        
        /// <summary>
        /// 图像主体区域。
        /// </summary>
        [JsonProperty("Box")]
        public Box Box{ get; set; }

        /// <summary>
        /// 主体类别ID。
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 整张图颜色信息。
        /// </summary>
        [JsonProperty("Colors")]
        public ColorInfo[] Colors{ get; set; }

        /// <summary>
        /// 属性信息。
        /// </summary>
        [JsonProperty("Attributes")]
        public Attribute[] Attributes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Box.", this.Box);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamArrayObj(map, prefix + "Colors.", this.Colors);
            this.SetParamArrayObj(map, prefix + "Attributes.", this.Attributes);
        }
    }
}

