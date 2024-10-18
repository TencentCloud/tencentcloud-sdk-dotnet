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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySecLogJoinObjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志类型
        /// bash日志: container_bash
        /// 容器启动: container_launch
        /// k8sApi: k8s_api
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 绑定列表
        /// </summary>
        [JsonProperty("BindList")]
        public string[] BindList{ get; set; }

        /// <summary>
        /// 待解绑列表，节点范围为全部时，含义为需剔除资产列表
        /// </summary>
        [JsonProperty("UnBindList")]
        public string[] UnBindList{ get; set; }

        /// <summary>
        /// 节点类型:
        /// NORMAL: 普通节点(默认值)
        /// SUPER: 超级节点
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 日志节点范围类型,0自选 1全部
        /// </summary>
        [JsonProperty("RangeType")]
        public long? RangeType{ get; set; }

        /// <summary>
        /// 新增资产是否自动加入，节点范围为全部时生效
        /// </summary>
        [JsonProperty("AutoJoin")]
        public bool? AutoJoin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamArraySimple(map, prefix + "BindList.", this.BindList);
            this.SetParamArraySimple(map, prefix + "UnBindList.", this.UnBindList);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "AutoJoin", this.AutoJoin);
        }
    }
}

