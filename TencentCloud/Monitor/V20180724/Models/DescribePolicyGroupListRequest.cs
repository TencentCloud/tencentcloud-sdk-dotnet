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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyGroupListRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定值，为"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 分页参数，每页返回的数量，取值1~100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页参数，页偏移量，从0开始计数
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 按策略名搜索
        /// </summary>
        [JsonProperty("Like")]
        public string Like{ get; set; }

        /// <summary>
        /// 实例分组id
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// 按更新时间排序, asc 或者 desc
        /// </summary>
        [JsonProperty("UpdateTimeOrder")]
        public string UpdateTimeOrder{ get; set; }

        /// <summary>
        /// 项目id列表
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 告警策略类型列表
        /// </summary>
        [JsonProperty("ViewNames")]
        public string[] ViewNames{ get; set; }

        /// <summary>
        /// 是否过滤无接收人策略组, 1表示过滤, 0表示不过滤
        /// </summary>
        [JsonProperty("FilterUnuseReceiver")]
        public long? FilterUnuseReceiver{ get; set; }

        /// <summary>
        /// 过滤条件, 接收组列表
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// 过滤条件, 接收人列表
        /// </summary>
        [JsonProperty("ReceiverUserList")]
        public string[] ReceiverUserList{ get; set; }

        /// <summary>
        /// 维度组合字段(json字符串), 例如[[{"name":"unInstanceId","value":"ins-6e4b2aaa"}]]
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// 模板策略组id, 多个id用逗号分隔
        /// </summary>
        [JsonProperty("ConditionTempGroupId")]
        public string ConditionTempGroupId{ get; set; }

        /// <summary>
        /// 过滤条件, 接收人或者接收组, user表示接收人, group表示接收组
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// 过滤条件，告警策略是否已启动或停止
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

