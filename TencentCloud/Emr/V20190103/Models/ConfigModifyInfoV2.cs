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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigModifyInfoV2 : AbstractModel
    {
        
        /// <summary>
        /// 操作类型，可选值：
        /// 
        /// - 0：新建队列
        /// - 1：编辑-全量覆盖
        /// - 2：新建子队列
        /// - 3：删除
        /// - 4：克隆，与新建子队列的行为一样，特别的对于`fair`，可以复制子队列到新建队列
        /// - 6：编辑-增量更新
        /// </summary>
        [JsonProperty("OpType")]
        public ulong? OpType{ get; set; }

        /// <summary>
        /// 队列名称，不支持修改。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 新建队列 传root的MyId；新建子队列 传 选中队列的 myId；克隆 要传 选中队列 parentId
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// 编辑、删除 传选中队列的 myId。克隆只有在调度器是`fair`时才需要传，用来复制子队列到新队列。
        /// </summary>
        [JsonProperty("MyId")]
        public string MyId{ get; set; }

        /// <summary>
        /// 基础配置信息。key的取值与**DescribeYarnQueue**返回的字段一致。
        /// ###### 公平调度器
        /// key的取值信息如下：
        /// 
        /// - type，父队列，取值为 **parent** 或 **null**
        /// - aclSubmitApps，提交访问控制，取值为**AclForYarnQueue类型的json串**或**null**
        /// - aclAdministerApps，管理访问控制，取值为**AclForYarnQueue类型的json串**或**null**
        /// - minSharePreemptionTimeout，最小共享优先权超时时间，取值为**数字字符串**或**null**
        /// - fairSharePreemptionTimeout，公平份额抢占超时时间，取值为**数字字符串**或**null**
        /// - fairSharePreemptionThreshold，公平份额抢占阈值，取值为**数字字符串**或**null**，其中数字的范围是（0，1]
        /// - allowPreemptionFrom，抢占模式，取值为**布尔字符串**或**null**
        /// - schedulingPolicy，调度策略，取值为**drf**、**fair**、**fifo**或**null**
        /// 
        /// ```
        /// type AclForYarnQueue struct {
        /// 	User  *string `json:"user"` //用户名
        /// 	Group *string `json:"group"`//组名
        /// }
        /// ```
        /// ###### 容量调度器
        /// key的取值信息如下：
        /// 
        /// - state，队列状态，取值为**STOPPED**或**RUNNING**
        /// - default-node-label-expression，默认标签表达式，取值为**标签**或**null**
        /// - acl_submit_applications，提交访问控制，取值为**AclForYarnQueue类型的json串**或**null**
        /// - acl_administer_queue，管理访问控制，取值为**AclForYarnQueue类型的json串**或**null**
        /// - maximum-allocation-mb，分配Container最大内存数量，取值为**数字字符串**或**null**
        /// - maximum-allocation-vcores，Container最大vCore数量，取值为**数字字符串**或**null**
        /// ```
        /// type AclForYarnQueue struct {
        /// 	User  *string `json:"user"` //用户名
        /// 	Group *string `json:"group"`//组名
        /// }
        /// ```
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicParams")]
        public ItemSeq BasicParams{ get; set; }

        /// <summary>
        /// 配置集信息，取值见该复杂类型的参数说明。配置集是计划模式在队列中表现，表示的是不同时间段不同的配置值，所有队列的配置集名称都一样，对于单个队列，每个配置集中的标签与参数都一样，只是参数值不同。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigSetParams")]
        public ConfigSetInfo[] ConfigSetParams{ get; set; }

        /// <summary>
        /// 容量调度专用，`OpType`为`6`时才生效，表示要删除这个队列中的哪些标签。优先级高于ConfigSetParams中的LabelParams。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteLables")]
        public string[] DeleteLables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "MyId", this.MyId);
            this.SetParamObj(map, prefix + "BasicParams.", this.BasicParams);
            this.SetParamArrayObj(map, prefix + "ConfigSetParams.", this.ConfigSetParams);
            this.SetParamArraySimple(map, prefix + "DeleteLables.", this.DeleteLables);
        }
    }
}

