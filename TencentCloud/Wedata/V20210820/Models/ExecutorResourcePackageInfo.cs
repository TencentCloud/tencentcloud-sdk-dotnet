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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutorResourcePackageInfo : AbstractModel
    {
        
        /// <summary>
        /// 资源包规格相关：资源包个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourcePackageNum")]
        public long? ResourcePackageNum{ get; set; }

        /// <summary>
        /// 资源包规格相关：cpu个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// 资源包id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorResourcePackageId")]
        public string ExecutorResourcePackageId{ get; set; }

        /// <summary>
        /// 资源包规格相关：内存大小，单位:G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// 资源包状态， /**
        ///      * 初始化中
        ///      */
        ///     INIT(0),
        ///     /**
        ///      * 运行中
        ///      */
        ///     RUNNING(1),
        ///     /**
        ///      * 运行异常
        ///      */
        ///     RUNNING_FAILED(2),
        ///     /**
        ///      * 释放中
        ///      */
        ///     DELETEING(3),
        ///     /**
        ///      * 已释放
        ///      */
        ///     DELETED(4),
        ///     /**
        ///      * 创建中
        ///      */
        ///     CREATING(5),
        ///     /**
        ///      * 创建失败
        ///      */
        ///     CREATE_FAILED(6),
        ///     /**
        ///      * 更新中
        ///      */
        ///     UPDATING(7),
        ///     /**
        ///      * 更新失败
        ///      */
        ///     UPDATE_FAILED(8),
        ///     /**
        ///      * 已到期
        ///      */
        ///     EXPIRED(9);
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 资源包状态描述：保存创建失败，运行异常和更新失败的原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusDescription")]
        public string StatusDescription{ get; set; }

        /// <summary>
        /// 资源包到期时间，时间戳毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 资源包额外属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public ExecutorResourcePackageExtInfo ExtInfo{ get; set; }

        /// <summary>
        /// 绑定的项目id，可为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 资源组绑定的时间，时间戳毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectBindTime")]
        public long? ProjectBindTime{ get; set; }

        /// <summary>
        /// 资源包使用状态: cpu使用，内存使用及趋势
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourcePackageUsage")]
        public ExecutorResourcePackageUsageInfo ResourcePackageUsage{ get; set; }

        /// <summary>
        /// 计费相关：产品资源id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductResourceIdList")]
        public long?[] ProductResourceIdList{ get; set; }

        /// <summary>
        /// 生命周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifeTime")]
        public long? LifeTime{ get; set; }

        /// <summary>
        /// 私有网络Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 子网Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 执行资源相关：资源规格描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceStandard")]
        public string ResourceStandard{ get; set; }

        /// <summary>
        /// 内存总数
        /// </summary>
        [JsonProperty("TotalMemory")]
        public ulong? TotalMemory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourcePackageNum", this.ResourcePackageNum);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "ExecutorResourcePackageId", this.ExecutorResourcePackageId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDescription", this.StatusDescription);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamObj(map, prefix + "ExtInfo.", this.ExtInfo);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectBindTime", this.ProjectBindTime);
            this.SetParamObj(map, prefix + "ResourcePackageUsage.", this.ResourcePackageUsage);
            this.SetParamArraySimple(map, prefix + "ProductResourceIdList.", this.ProductResourceIdList);
            this.SetParamSimple(map, prefix + "LifeTime", this.LifeTime);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "ResourceStandard", this.ResourceStandard);
            this.SetParamSimple(map, prefix + "TotalMemory", this.TotalMemory);
        }
    }
}

