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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyGroupListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>固定值，为&quot;monitor&quot;</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>分页参数，每页返回的数量，取值1~100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页参数，页偏移量，从0开始计数</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>按策略名搜索</p>
        /// </summary>
        [JsonProperty("Like")]
        public string Like{ get; set; }

        /// <summary>
        /// <p>实例分组id</p>
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// <p>按更新时间排序, asc 或者 desc</p>
        /// </summary>
        [JsonProperty("UpdateTimeOrder")]
        public string UpdateTimeOrder{ get; set; }

        /// <summary>
        /// <p>项目id列表</p>
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// <p>告警策略类型列表</p>
        /// </summary>
        [JsonProperty("ViewNames")]
        public string[] ViewNames{ get; set; }

        /// <summary>
        /// <p>是否过滤无接收人策略组, 1表示过滤, 0表示不过滤</p>
        /// </summary>
        [JsonProperty("FilterUnuseReceiver")]
        public long? FilterUnuseReceiver{ get; set; }

        /// <summary>
        /// <p>过滤条件, 接收组列表</p>
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// <p>过滤条件, 接收人列表</p>
        /// </summary>
        [JsonProperty("ReceiverUserList")]
        public string[] ReceiverUserList{ get; set; }

        /// <summary>
        /// <p>维度组合字段(json字符串), 例如[[{&quot;name&quot;:&quot;unInstanceId&quot;,&quot;value&quot;:&quot;ins-6e4b2aaa&quot;}]]</p>
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// <p>模板策略组id, 多个id用逗号分隔</p>
        /// </summary>
        [JsonProperty("ConditionTempGroupId")]
        public string ConditionTempGroupId{ get; set; }

        /// <summary>
        /// <p>过滤条件, 接收人或者接收组, user表示接收人, group表示接收组</p>
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// <p>过滤条件，告警策略是否已启动或停止</p>
        /// </summary>
        [JsonProperty("IsOpen")]
        public bool? IsOpen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Like", this.Like);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "UpdateTimeOrder", this.UpdateTimeOrder);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ViewNames.", this.ViewNames);
            this.SetParamSimple(map, prefix + "FilterUnuseReceiver", this.FilterUnuseReceiver);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamArraySimple(map, prefix + "ReceiverUserList.", this.ReceiverUserList);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamSimple(map, prefix + "ConditionTempGroupId", this.ConditionTempGroupId);
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
        }
    }
}

