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
        /// 图库类型： 
        /// 1: 通用图库，以用户输入图提取特征。
        /// 2: 灰度图库，输入图和搜索图均转为灰度图提取特征。
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

