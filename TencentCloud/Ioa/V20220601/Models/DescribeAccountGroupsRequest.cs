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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccountGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索范围：0-仅当前分组的直接子组，1-当前分组的所有子组。默认为0。
        /// </summary>
        [JsonProperty("Deepin")]
        public long? Deepin{ get; set; }

        /// <summary>
        /// 查询条件
        /// 
        /// 过滤参数
        /// 1、Name，string类型，按分组名过滤
        /// 是否必填：否
        /// 操作符: like
        /// 
        /// 排序条件
        /// 1、Itime，string类型，按分组创建时间排序
        /// 是否必填：否
        /// 2、Utime，string类型，按分组更新时间排序
        /// 是否必填：否
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// 父分组ID，获取该分组下的子组信息。默认查询全网根分组下子组信息。
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Deepin", this.Deepin);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
        }
    }
}

