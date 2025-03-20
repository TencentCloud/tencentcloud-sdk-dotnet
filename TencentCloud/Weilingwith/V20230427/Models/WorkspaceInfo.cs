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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkspaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 工作空间Id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 工作空间中文名字
        /// </summary>
        [JsonProperty("ChineseName")]
        public string ChineseName{ get; set; }

        /// <summary>
        /// 工作空间描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工作空间是否删除状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 该工作空间绑定的区/县的行政区名字
        /// </summary>
        [JsonProperty("ParkName")]
        public string ParkName{ get; set; }

        /// <summary>
        /// 该工作空间绑定的区/县的行政区编码
        /// </summary>
        [JsonProperty("ParkNum")]
        public string ParkNum{ get; set; }

        /// <summary>
        /// 获取该工作空间绑定的区/县的上级行政区划信息
        /// </summary>
        [JsonProperty("AdministrativeDetailSet")]
        public AdministrativeDetail[] AdministrativeDetailSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ChineseName", this.ChineseName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ParkName", this.ParkName);
            this.SetParamSimple(map, prefix + "ParkNum", this.ParkNum);
            this.SetParamArrayObj(map, prefix + "AdministrativeDetailSet.", this.AdministrativeDetailSet);
        }
    }
}

