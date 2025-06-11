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

    public class DescribeDeviceHardwareInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 【必填】设备分组id（需要和OsType匹配），下面是私有化场景下默认id：id-名称-操作系统1	全网终端	Win2	未分组终端	Win30000000	服务器	Win40000101	全网终端	Linux40000102	未分组终端	Linux40000103	服务器	Linux40000201	全网终端	macOS40000202	未分组终端	macOS40000203	服务器	macOS40000401	全网终端	Android40000402	未分组终端	Android40000501	全网终端	iOS40000502	未分组终端	iOSSaaS需要调用分组接口DescribeDeviceChildGroups获取对应分组id
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 【必填】操作系统类型（0: win，1：linux，2: mac，4：android，5：ios   默认值0），需要和GroupId或者GroupIds匹配
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 过滤条件参数（字段含义请参考接口返回值）  - Name, 类型String，支持操作：【eq，like，ilike】，支持排序  - UserName, 类型String，支持操作：【eq，like，ilike】，支持排序  - IoaUserName，类型String，支持操作：【eq，like，ilike】，支持排序  - MacAddr, 类型String，支持操作：【eq，like，ilike】，支持排序  - Ip, 类型String，支持操作：【eq，like，ilike】，支持排序  - Mid, 类型String，支持操作：【eq，like，ilike】，支持排序  ，支持排序分页参数  - PageNum 从1开始，小于等于0时使用默认参数 - PageSize 最大值5000，最好不超过100
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
        }
    }
}

