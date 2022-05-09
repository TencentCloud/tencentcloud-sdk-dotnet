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

    public class GroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 图库Id。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 图库名称。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 图库简介。
        /// </summary>
        [JsonProperty("Brief")]
        public string Brief{ get; set; }

        /// <summary>
        /// 图库容量。
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public ulong? MaxCapacity{ get; set; }

        /// <summary>
        /// 该库的访问限频 。
        /// </summary>
        [JsonProperty("MaxQps")]
        public ulong? MaxQps{ get; set; }

        /// <summary>
        /// 图库类型，对应不同服务类型，默认为1。建议手动调整为4～6，1～3为历史版本，不推荐。
        /// 参数值：
        /// 4：在自建图库中搜索相同原图，可支持裁剪、翻转、调色、加水印后的图片搜索，适用于图片版权保护、原图查询等场景。
        /// 5：在自建图库中搜索相同或相似的商品图片，适用于商品分类、检索、推荐等电商场景。
        /// 6：在自建图片库中搜索与输入图片高度相似的图片，适用于相似图案、logo、纹理等图像元素的搜索。
        /// </summary>
        [JsonProperty("GroupType")]
        public ulong? GroupType{ get; set; }

        /// <summary>
        /// 图库图片数量。
        /// </summary>
        [JsonProperty("PicCount")]
        public ulong? PicCount{ get; set; }

        /// <summary>
        /// 图库创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 图库更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Brief", this.Brief);
            this.SetParamSimple(map, prefix + "MaxCapacity", this.MaxCapacity);
            this.SetParamSimple(map, prefix + "MaxQps", this.MaxQps);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "PicCount", this.PicCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

