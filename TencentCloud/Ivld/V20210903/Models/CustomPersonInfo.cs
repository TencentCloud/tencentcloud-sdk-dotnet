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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomPersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 自定义人物Id
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 自定义人物姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 自定义人物简介信息
        /// </summary>
        [JsonProperty("BasicInfo")]
        public string BasicInfo{ get; set; }

        /// <summary>
        /// 一级自定义人物类型
        /// </summary>
        [JsonProperty("L1Category")]
        public string L1Category{ get; set; }

        /// <summary>
        /// 二级自定义人物类型
        /// </summary>
        [JsonProperty("L2Category")]
        public string L2Category{ get; set; }

        /// <summary>
        /// 自定义人物图片信息
        /// </summary>
        [JsonProperty("ImageInfoSet")]
        public PersonImageInfo[] ImageInfoSet{ get; set; }

        /// <summary>
        /// 自定义人物创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BasicInfo", this.BasicInfo);
            this.SetParamSimple(map, prefix + "L1Category", this.L1Category);
            this.SetParamSimple(map, prefix + "L2Category", this.L2Category);
            this.SetParamArrayObj(map, prefix + "ImageInfoSet.", this.ImageInfoSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

