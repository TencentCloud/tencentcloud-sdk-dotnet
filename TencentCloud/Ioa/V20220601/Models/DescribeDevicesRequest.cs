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

    public class DescribeDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件<br>
        /// <li>Ip - String - 是否必填：否 - 操作符: eq  - 排序支持：否- 按照Ip进行过滤。</li>
        /// <li>MacAddr - String - 是否必填：否 - 操作符: eq  - 排序支持：否- 按照mac地址进行过滤。</li>
        /// <li>IoaUserName - String - 是否必填：否 - 操作符: eq  - 排序支持：否- 按照ioa用户名进行过滤。</li>
        /// 分页参数<br>
        /// <li>PageNum 从1开始，小于等于0时使用默认参数。</li>
        /// <li>PageSize 最大值5000，最好不超过100。</li>
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }

        /// <summary>
        /// 【和GroupIds必须有一个填写】设备分组id（需要和OsType匹配）
        /// id-名称-操作系统
        /// 1	全网终端	Win
        /// 2	未分组终端	Win
        /// 30000000	服务器	Win
        /// 40000101	全网终端	Linux
        /// 40000102	未分组终端	Linux
        /// 40000103	服务器	Linux
        /// 40000201	全网终端	macOS
        /// 40000202	未分组终端	macOS
        /// 40000203	服务器	macOS
        /// 40000401	全网终端	Android
        /// 40000402	未分组终端	Android
        /// 40000501	全网终端	iOS
        /// 40000502	未分组终端	iOS
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 【必填】操作系统类型（0: win，1：linux，2: mac，3: win_srv，4：android，5：ios   默认值0），需要和GroupId或者GroupIds匹配
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 在线状态 （2表示在线，0或者1表示离线）
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// 过滤条件--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }

        /// <summary>
        /// 获取第几页--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// 每页获取数--兼容旧接口,参数同Condition
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 授权状态 4未授权 5已授权
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

