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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCustomersRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询类型，0.个人，1负责部门，2.指定部门
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 是否星级标记 1是 0否
        /// </summary>
        [JsonProperty("MarkFlag")]
        public long? MarkFlag{ get; set; }

        /// <summary>
        /// 客户标签，多个标签用逗号隔开
        /// </summary>
        [JsonProperty("TagIds")]
        public string TagIds{ get; set; }

        /// <summary>
        /// 员工标识筛选，0：非员工，1：员工
        /// </summary>
        [JsonProperty("RelChannelFlag")]
        public string RelChannelFlag{ get; set; }

        /// <summary>
        /// 必须存在手机 1是 0否
        /// </summary>
        [JsonProperty("NeedPhoneFlag")]
        public long? NeedPhoneFlag{ get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 性别 1男 2女
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }

        /// <summary>
        /// 查询开始位置
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页记录条数
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 子项目ID
        /// </summary>
        [JsonProperty("SubProjectId")]
        public string SubProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "MarkFlag", this.MarkFlag);
            this.SetParamSimple(map, prefix + "TagIds", this.TagIds);
            this.SetParamSimple(map, prefix + "RelChannelFlag", this.RelChannelFlag);
            this.SetParamSimple(map, prefix + "NeedPhoneFlag", this.NeedPhoneFlag);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SubProjectId", this.SubProjectId);
        }
    }
}

