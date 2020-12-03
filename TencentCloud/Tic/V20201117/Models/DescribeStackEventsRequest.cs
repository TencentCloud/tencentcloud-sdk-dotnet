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

namespace TencentCloud.Tic.V20201117.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStackEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照⼀个或者多个事件ID查询
        /// </summary>
        [JsonProperty("EventIds")]
        public string[] EventIds{ get; set; }

        /// <summary>
        /// 过滤条件
        /// 
        /// # VersionId
        /// 按照版本ID过滤，VersionId形如 ver-kg8hn58h
        /// 类型：string
        /// 必须：否
        /// 
        /// # StackId
        /// 按照资源栈ID过滤，StackId形如 stk-hz5vn3te
        /// 类型：string
        /// 必选：否
        /// 
        /// # Type
        /// 按照事件类型过滤，Type形如 plan, apply, destroy
        /// 类型：string
        /// 必选：否
        /// 
        /// # Status
        /// 按照事件状态过滤，Status形如 queueing, running, success, failed
        /// 类型：string
        /// 必选：否
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventIds.", this.EventIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

