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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNodeGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 节点类型。0: 全部 1: IDC 2: LastMile 3: Mobile，不填默认为0
        /// </summary>
        [JsonProperty("NodeType")]
        public long?[] NodeType{ get; set; }

        /// <summary>
        /// 节点分类。0: 全部 1: PC 2：Mobile，不填默认为0。PC分类包括IDC和LM节点类型，Mobile分类包括Mobile节点类型。与NodeType参数取交集。
        /// </summary>
        [JsonProperty("TaskCategory")]
        public long? TaskCategory{ get; set; }

        /// <summary>
        /// IP类型。0: 全部 1: IPv4 2: IPv6，不填默认为0
        /// </summary>
        [JsonProperty("IPType")]
        public long? IPType{ get; set; }

        /// <summary>
        /// 拨测点描述关键词。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 地域ID。0: 精选拨测点 1: 国内 2: 港澳台 3: 亚太 4: 欧洲与美洲 5: 非洲与大洋洲，不填默认为0
        /// </summary>
        [JsonProperty("RegionID")]
        public long? RegionID{ get; set; }

        /// <summary>
        /// 省份或国家ID。0表示全部，不填默认为0
        /// </summary>
        [JsonProperty("DistrictID")]
        public long? DistrictID{ get; set; }

        /// <summary>
        /// 运营商ID。0: 全部 1: 中国电信 2: 中国联通 3: 中国移动 99: 其他，不填默认为0
        /// </summary>
        [JsonProperty("NetServiceID")]
        public long? NetServiceID{ get; set; }

        /// <summary>
        /// 节点组类型。0: 高级拨测点组 1: 可用性节点 2: 我的拨测点组，不填默认为0
        /// </summary>
        [JsonProperty("NodeGroupType")]
        public long? NodeGroupType{ get; set; }

        /// <summary>
        /// 任务类型，如1、2、3、4、5、6、7；1-页面性能、2-文件上传、3-文件下载、4-端口性能、5-网络质量、6-音视频体验、7-域名whois，不填默认为0，不对任务类型做过滤
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 测试类型，包含定时测试与即时测试。0-定时拨测，其它表示即时拨测。
        /// </summary>
        [JsonProperty("ProbeType")]
        public ulong? ProbeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NodeType.", this.NodeType);
            this.SetParamSimple(map, prefix + "TaskCategory", this.TaskCategory);
            this.SetParamSimple(map, prefix + "IPType", this.IPType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RegionID", this.RegionID);
            this.SetParamSimple(map, prefix + "DistrictID", this.DistrictID);
            this.SetParamSimple(map, prefix + "NetServiceID", this.NetServiceID);
            this.SetParamSimple(map, prefix + "NodeGroupType", this.NodeGroupType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ProbeType", this.ProbeType);
        }
    }
}

