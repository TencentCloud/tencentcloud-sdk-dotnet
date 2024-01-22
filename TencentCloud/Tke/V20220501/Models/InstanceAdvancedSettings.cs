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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// 该节点属于podCIDR大小自定义模式时，可指定节点上运行的pod数量上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DesiredPodNumber")]
        public long? DesiredPodNumber{ get; set; }

        /// <summary>
        /// base64 编码的用户脚本，在初始化节点之前执行，目前只对添加已有节点生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }

        /// <summary>
        /// 运行时描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public RuntimeConfig RuntimeConfig{ get; set; }

        /// <summary>
        /// base64 编码的用户脚本, 此脚本会在 k8s 组件运行后执行, 需要用户保证脚本的可重入及重试逻辑, 脚本及其生成的日志文件可在节点的 /data/ccs_userscript/ 路径查看, 如果要求节点需要在进行初始化完成后才可加入调度, 可配合 unschedulable 参数使用, 在 userScript 最后初始化完成后, 添加 kubectl uncordon nodename --kubeconfig=/root/.kube/config 命令使节点加入调度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// 节点相关的自定义参数信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public InstanceExtraArgs ExtraArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DesiredPodNumber", this.DesiredPodNumber);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
        }
    }
}

