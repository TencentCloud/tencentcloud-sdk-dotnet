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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupItem : AbstractModel
    {
        
        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 父分组ID
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 分组路径
        /// </summary>
        [JsonProperty("GroupPath")]
        public string GroupPath{ get; set; }

        /// <summary>
        /// 分组描述
        /// </summary>
        [JsonProperty("GroupDescribe")]
        public string GroupDescribe{ get; set; }

        /// <summary>
        /// 分组绑定设备数
        /// </summary>
        [JsonProperty("DeviceNum")]
        public long? DeviceNum{ get; set; }

        /// <summary>
        /// 子分组数量
        /// </summary>
        [JsonProperty("SubGroupNum")]
        public long? SubGroupNum{ get; set; }

        /// <summary>
        /// 分组附加信息
        /// </summary>
        [JsonProperty("ExtraInformation")]
        public string ExtraInformation{ get; set; }

        /// <summary>
        /// 分组类型
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 分组状态
        /// </summary>
        [JsonProperty("GroupStatus")]
        public long? GroupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupPath", this.GroupPath);
            this.SetParamSimple(map, prefix + "GroupDescribe", this.GroupDescribe);
            this.SetParamSimple(map, prefix + "DeviceNum", this.DeviceNum);
            this.SetParamSimple(map, prefix + "SubGroupNum", this.SubGroupNum);
            this.SetParamSimple(map, prefix + "ExtraInformation", this.ExtraInformation);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
        }
    }
}

